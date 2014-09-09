using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using EdFi.Rest.Api;
using EdFi.Rest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class BulkOperationFixture : BaseFixture
    {
        private class Interchange
        {
            public string BulkOperationId { get; set; }
            public string FileUploadId { get; set; }
            public string FileName { get; set; }
            public string Xml { get; set; }
            public string InterchangeType { get; set; }
            public long Length { get; set; }

            public string Format
            {
                get { return "text/xml"; }
            }

            public Interchange()
            {
            }

            public Interchange(string fileName, string interchangeType)
            {
                FileName = fileName;
                InterchangeType = interchangeType;
                Length = new FileInfo(FileName).Length;
            }

            public Stream CreateStream()
            {
                if (!string.IsNullOrEmpty(Xml))
                {
                    var stream = new MemoryStream();
                    var writer = new StreamWriter(stream);

                    writer.Write(Xml);
                    writer.Flush();
                    stream.Position = 0;

                    return stream;
                }

                if (!string.IsNullOrEmpty(FileName))
                {
                    return new FileStream(FileName, FileMode.Open);
                }

                return null;
            }
        }

        private static string UploadInterchanges(List<Interchange> interchanges)
        {
            var client = GetClientWithSchoolYear();
            var bulkOperationsApi = new BulkOperationsApi(client);
            var postResponse =
                bulkOperationsApi.PostBulkOperations(new BulkOperation
                {
                    uploadFiles =
                        interchanges.Select(
                            x =>
                            new UploadFile
                            {
                                format = x.Format,
                                interchangeType = x.InterchangeType,
                                size = x.Length
                            }).ToList()
                });

            Assert.AreEqual(HttpStatusCode.Created, postResponse.StatusCode);

            var bulkOperation = postResponse.Data;
            var uploadApi = new UploadsApi(client);

            interchanges.ForEach(x => x.BulkOperationId = bulkOperation.id);

            interchanges.ForEach(
                x =>
                x.FileUploadId =
                bulkOperation.uploadFiles.Single(
                    uploadFile =>
                    uploadFile.interchangeType.ToLower() == x.InterchangeType && uploadFile.size == x.Length).id);

            foreach (var interchange in interchanges)
            {
                using (var stream = interchange.CreateStream())
                {
                    ChunkUpload(uploadApi, interchange.FileUploadId, stream, interchange.Length);
                }
            }

            bulkOperation = bulkOperationsApi.GetBulkOperationsById(bulkOperation.id).Data;

            bulkOperation.uploadFiles.ForEach(x => Assert.IsTrue(x.status == "Incomplete" || x.status == "Initialized"));

            // Commit the files.
            bulkOperation.uploadFiles.ForEach(x => uploadApi.CommitUploads(new Upload { id = x.id }));

            while (bulkOperation.status != "Completed" && bulkOperation.status != "Error")
            {
                Thread.Sleep(1000);
                bulkOperation = bulkOperationsApi.GetBulkOperationsById(bulkOperation.id).Data;
            }

            // While we're here, we could do additional work around retrieving exceptions.
            var bulkOperationExceptionsApi = new BulkOperationExceptionsApi(client);
            string exceptionContent = string.Empty;

            foreach (var uploadFile in bulkOperation.uploadFiles)
            {
                var offset = 0;
                var limit = 50;
                IRestResponse<List<BulkOperationException>> exceptions = null;

                do
                {
                    exceptions = bulkOperationExceptionsApi.GetBulkOperationExceptions(bulkOperation.id,
                                                                                       uploadFile.id, limit,
                                                                                       offset);

                    foreach (BulkOperationException bulkOperationException in exceptions.Data)
                    {
                        Console.WriteLine("Exception Message: '{0}'", bulkOperationException.message);
                    }

                    // Do we still have generic errors coming out of the bulk operations?
                    var exceptionContentThisFile = exceptions.Content;
                    var hasInternalServerError = exceptionContentThisFile.ToLower().Contains("unexpected error");
                    Assert.IsFalse(hasInternalServerError);

                    // This shouldn't be returned just because no entities were processed.
                    Assert.IsFalse(exceptionContentThisFile.ToLower().Contains("no aggregates for interchange "));

                    // This should obviously never happen.
                    Assert.IsFalse(exceptionContentThisFile.ToLower().Contains("object reference not set to"));

                    if (exceptionContentThisFile != null) exceptions.Content += " ";

                    exceptionContent += exceptionContentThisFile;

                    offset += limit;
                } while (exceptions.Data.Count > 0);
            }

            // The test should not come back with no exceptions and a status of "Error".
            if (exceptionContent.Trim() == "[]")
                Assert.AreNotEqual("Error", bulkOperation.status);

            return exceptionContent;
        }

        private static void ChunkUpload(UploadsApi uploadApi, string uploadId, Stream stream, long fileLength)
        {
            int offset = 0;
            const long maximumChunkSize = 4000000;

            // Loop to simulate chunking.
            while (offset < fileLength)
            {
                var chunkSize = (offset + maximumChunkSize) <= fileLength
                                    ? maximumChunkSize
                                    : fileLength - offset;
                var fileBytes = new byte[chunkSize];

                stream.Read(fileBytes, 0, fileBytes.Length);

                var uploadResponse = uploadApi.PostUploads(new Upload
                {
                    id = uploadId,
                    size = fileBytes.Length,
                    offset = offset,
                    // These will be file bytes for the real implementation.
                    fileBytes = fileBytes
                });

                offset += (int)chunkSize;
            }
        }

        [TestMethod]
        public void When_Committing_EducationOrgCalendar_Interchange_Should_Insert_All_Records()
        {
            var interchanges = new List<Interchange>
                                   {
                                       new Interchange
                                           (
                                           @"SampleXml\When_Committing_EducationOrgCalendar_Interchange_Should_Insert_All_Records.xml",
                                           "educationorgcalendar"
                                           )
                                   };

            var exceptionContent = UploadInterchanges(interchanges);
            var calendarDatesApi = new CalendarDatesApi(GetClientWithSchoolYear());

            // This test is skipping every other calendar date because there is no carriage return between one calendar date
            // and the next in the Xml file.

            Assert.AreEqual(HttpStatusCode.OK, calendarDatesApi.GetCalendarDateByKey(450, new DateTime(2013, 08, 01), string.Empty).StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, calendarDatesApi.GetCalendarDateByKey(450, new DateTime(2013, 08, 02), string.Empty).StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, calendarDatesApi.GetCalendarDateByKey(450, new DateTime(2013, 08, 05), string.Empty).StatusCode);
        }

        [TestMethod]
        public void When_Committing_Student_Gradebook_Should_Throw_Errors()
        {
            var interchanges = new List<Interchange>
                                       {
                                           new Interchange
                                               {
                                                   InterchangeType = "studentgradebook",
                                                   Xml =
                                                       string.Format(
                                                           File.ReadAllText(
                                                               @"SampleXml\When_Committing_Student_Gradebook_Should_Throw_Errors.xml"))
                                               }
                                       };

            interchanges.ForEach(x => x.Length = x.Xml.Length);

            UploadInterchanges(interchanges);

            // This is just an example. We won't bother with an assertion here. However, that makes this
            // a test without actually testing anything.
        }
    }
}
