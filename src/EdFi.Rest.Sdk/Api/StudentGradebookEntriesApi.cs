  using System;
  using System.Collections.Generic;
  using EdFi.Rest.Sdk;
  using EdFi.Rest.Models;
  using RestSharp;
  
  namespace EdFi.Rest.Api {
    public class StudentGradebookEntriesApi {

      private readonly IRestClient client;

      public StudentGradebookEntriesApi(IRestClient client)
      {
            this.client = client;
      }
      
      /// <summary>
      /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
      /// </summary>
      /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
      /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
      /// <returns></returns>
      public IRestResponse<List<StudentGradebookEntry>> GetStudentGradebookEntriesAll(int? offset, int? limit) {
        var request = new RestRequest("/studentGradebookEntries", Method.GET);
        request.RequestFormat = DataFormat.Json;

        if (offset != null){
          request.AddParameter("offset", offset);
		}
        if (limit != null){
          request.AddParameter("limit", limit);
		}
        return client.Execute<List<StudentGradebookEntry>>(request);   
      }
      /// <summary>
      /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
      /// </summary>
      /// <param name="studentUniqueId">A unique alpha-numeric code assigned to a student.</param>
      /// <param name="schoolId">School Identity Column</param>
      /// <param name="classPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period  </param>
      /// <param name="classroomIdentificationCode">A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.  </param>
      /// <param name="localCourseCode">The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.  </param>
      /// <param name="termType">The name of the term in which the section is offered (e.g., First semester, Second semester, Year long, summer school)  </param>
      /// <param name="schoolYear">The identifier for the school year (e.g., 2010/11).  </param>
      /// <param name="beginDate">Month, day and year of the student''s entry or assignment to the section.  If blank, default is the start date of the first grading period.  NEDM: EntryDate  </param>
      /// <param name="gradebookEntryTitle">The name or title of the activity to be recorded in the gradebook entry.</param>
      /// <param name="dateAssigned">The date the assignment, homework, or assessment was assigned or executed.</param>
      /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
      /// <returns></returns>
      public IRestResponse<StudentGradebookEntry> GetStudentGradebookEntryByKey(string studentUniqueId, int? schoolId, string classPeriodName, string classroomIdentificationCode, string localCourseCode, string termType, int? schoolYear, DateTime? beginDate, string gradebookEntryTitle, DateTime? dateAssigned, string IfNoneMatch) {
        var request = new RestRequest("/studentGradebookEntries", Method.GET);
        request.RequestFormat = DataFormat.Json;

        // verify required params are set
        if (studentUniqueId == null || schoolId == null || classPeriodName == null || classroomIdentificationCode == null || localCourseCode == null || termType == null || schoolYear == null || beginDate == null || gradebookEntryTitle == null || dateAssigned == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        if (studentUniqueId != null){
          request.AddParameter("studentUniqueId", studentUniqueId);
		}
        if (schoolId != null){
          request.AddParameter("schoolId", schoolId);
		}
        if (classPeriodName != null){
          request.AddParameter("classPeriodName", classPeriodName);
		}
        if (classroomIdentificationCode != null){
          request.AddParameter("classroomIdentificationCode", classroomIdentificationCode);
		}
        if (localCourseCode != null){
          request.AddParameter("localCourseCode", localCourseCode);
		}
        if (termType != null){
          request.AddParameter("termType", termType);
		}
        if (schoolYear != null){
          request.AddParameter("schoolYear", schoolYear);
		}
        if (beginDate != null){
          request.AddParameter("beginDate", beginDate);
		}
        if (gradebookEntryTitle != null){
          request.AddParameter("gradebookEntryTitle", gradebookEntryTitle);
		}
        if (dateAssigned != null){
          request.AddParameter("dateAssigned", dateAssigned);
		}
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<StudentGradebookEntry>(request);   
      }
      /// <summary>
      /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
      /// </summary>
      /// <param name="body">The JSON representation of the &quot;studentGradebookEntry&quot; resource to be created or updated.</param>
      /// <returns></returns>
      public IRestResponse PostStudentGradebookEntries(StudentGradebookEntry body) {
        var request = new RestRequest("/studentGradebookEntries", Method.POST);
        request.RequestFormat = DataFormat.Json;

        // verify required params are set
        if (body == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddBody(body);
        return client.Execute(request);   
      }
      /// <summary>
      /// Retrieves a specific resource using the resource's identifier (using the &quot;Get By Id&quot; pattern). This GET operation retrieves a resource by the specified resource identifier.
      /// </summary>
      /// <param name="id">A resource identifier specifying the resource to be retrieved.</param>
      /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
      /// <returns></returns>
      public IRestResponse<StudentGradebookEntry> GetStudentGradebookEntriesById(string id, string IfNoneMatch) {
        var request = new RestRequest("/studentGradebookEntries/{id}", Method.GET);
        request.RequestFormat = DataFormat.Json;

        request.AddUrlSegment("id", id);
        // verify required params are set
        if (id == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<StudentGradebookEntry>(request);   
      }
      /// <summary>
      /// Updates an existing resource based on the resource identifier. The PUT operation is used to update an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found and will not be created).  Additionally, natural key values cannot be changed using this operation, and will be not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
      /// </summary>
      /// <param name="id">A resource identifier specifying the resource to be updated.</param>
      /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
      /// <param name="body">The JSON representation of the &quot;studentGradebookEntry&quot; resource to be updated.</param>
      /// <returns></returns>
      public IRestResponse PutStudentGradebookEntry(string id, string IfMatch, StudentGradebookEntry body) {
        var request = new RestRequest("/studentGradebookEntries/{id}", Method.PUT);
        request.RequestFormat = DataFormat.Json;

        request.AddUrlSegment("id", id);
        // verify required params are set
        if (id == null || body == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddHeader("If-Match", IfMatch);
        request.AddBody(body);
        return client.Execute(request);   
      }
      /// <summary>
      /// Deletes an existing resource using the resource identifier. The DELETE operation is used to delete an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found).
      /// </summary>
      /// <param name="id">A resource identifier specifying the resource to be deleted.</param>
      /// <param name="IfMatch">The ETag header value used to prevent the DELETE from removing a resource modified by another consumer.</param>
      /// <returns></returns>
      public IRestResponse DeleteStudentGradebookEntryById(string id, string IfMatch) {
        var request = new RestRequest("/studentGradebookEntries/{id}", Method.DELETE);
        request.RequestFormat = DataFormat.Json;

        request.AddUrlSegment("id", id);
        // verify required params are set
        if (id == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddHeader("If-Match", IfMatch);
        return client.Execute(request);   
      }
      }
    }
