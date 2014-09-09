using System;
using System.Net;
using EdFi.Rest.Api;
using EdFi.Rest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Creating_And_Getting_A_Student_Without_An_Association : BaseFixture
    {
        [TestMethod]
        public void Should_Fail()
        {
            var identity = NewRandomIdentity();
            var identityApi = new IdentitiesApi(GetClientWithoutSchoolYear());
            var postIdentityResponse = identityApi.PostIdentity(identity);
            var api = new StudentsApi(GetClientWithSchoolYear());
            var student = new Student
                              {
                                  studentUniqueId = postIdentityResponse.Data.uniqueId,
                                  firstName = identity.givenNames,
                                  lastSurname = identity.familyNames,
                                  birthDate = DateTime.Parse(identity.birthDate),
                                  sexType = identity.birthGender
                              };

            // Create
            var postResponse = api.PostStudents(student);

            Assert.AreEqual(HttpStatusCode.Created, postResponse.StatusCode);

            // Update
            postResponse = api.PostStudents(student);

            Assert.AreEqual(HttpStatusCode.Forbidden, postResponse.StatusCode);

            var getResponse = api.GetStudentByKey(postIdentityResponse.Data.uniqueId, string.Empty);

            Assert.AreEqual(HttpStatusCode.Forbidden, getResponse.StatusCode);
        }
    }

    [TestClass]
    public class When_Creating_And_Getting_A_Student_With_An_Association : BaseFixture
    {
        [TestMethod]
        public void Should_Succeed()
        {
            var clientWithSchoolYear = GetClientWithSchoolYear();
            var identity = NewRandomIdentity();
            var identityApi = new IdentitiesApi(GetClientWithoutSchoolYear());
            var postIdentityResponse = identityApi.PostIdentity(identity);
            var studentsApi = new StudentsApi(clientWithSchoolYear);
            var student = new Student
            {
                studentUniqueId = postIdentityResponse.Data.uniqueId,
                firstName = identity.givenNames,
                lastSurname = identity.familyNames,
                birthDate = DateTime.Parse(identity.birthDate),
                sexType = identity.birthGender
            };

            // Create
            var postResponse = studentsApi.PostStudents(student);

            Assert.AreEqual(HttpStatusCode.Created, postResponse.StatusCode);

            var studentSchoolAssociationsApi = new StudentSchoolAssociationsApi(clientWithSchoolYear);

            studentSchoolAssociationsApi.PostStudentSchoolAssociations(new StudentSchoolAssociation
                                                                           {
                                                                               studentReference = new StudentReference{ studentUniqueId = postIdentityResponse.Data.uniqueId },
                                                                               schoolReference = new SchoolReference{ schoolId = SchoolId },
                                                                               entryDate = NewRandomDate(),
                                                                               schoolYearTypeReference = new SchoolYearTypeReference{ schoolYear = CurrentSchoolYear },
                                                                               entryGradeLevelDescriptor = GradeLevelDescriptor
                                                                           });

            // Update
            postResponse = studentsApi.PostStudents(student);

            Assert.AreEqual(HttpStatusCode.OK, postResponse.StatusCode);

            var getResponse = studentsApi.GetStudentByKey(postIdentityResponse.Data.uniqueId, string.Empty);

            Assert.AreEqual(HttpStatusCode.OK, getResponse.StatusCode);
        }
    }
}
