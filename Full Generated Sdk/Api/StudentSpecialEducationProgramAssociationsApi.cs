  using System;
  using System.Collections.Generic;
  using EdFi.Rest.Sdk;
  using EdFi.Rest.Models;
  using RestSharp;
  
  namespace EdFi.Rest.Api {
    public class StudentSpecialEducationProgramAssociationsApi {

      private readonly IRestClient client;

      public StudentSpecialEducationProgramAssociationsApi(IRestClient client)
      {
            this.client = client;
      }
      
      /// <summary>
      /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
      /// </summary>
      /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
      /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
      /// <returns></returns>
      public IRestResponse<List<StudentSpecialEducationProgramAssociation>> GetStudentSpecialEducationProgramAssociationsAll(int? offset, int? limit) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.GET);
        request.RequestFormat = DataFormat.Json;

        if (offset != null){
          request.AddParameter("offset", offset);
		}
        if (limit != null){
          request.AddParameter("limit", limit);
		}
        return client.Execute<List<StudentSpecialEducationProgramAssociation>>(request);   
      }
      /// <summary>
      /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
      /// </summary>
      /// <param name="studentUniqueId">A unique alpha-numeric code assigned to a student.</param>
      /// <param name="programType">The program associated with the student.</param>
      /// <param name="programEducationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
      /// <param name="beginDate">The month, day, and year on which the student first received services.  NEDM: Beginning Date  </param>
      /// <param name="programName">The formal name of the program of instruction, training, services or benefits available through federal, state, or local agencies.</param>
      /// <param name="educationOrganizationId">The education organization where the student is participating in or receiving the program services.</param>
      /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
      /// <returns></returns>
      public IRestResponse<StudentSpecialEducationProgramAssociation> GetStudentSpecialEducationProgramAssociationByKey(string studentUniqueId, string programType, int? programEducationOrganizationId, DateTime? beginDate, string programName, int? educationOrganizationId, string IfNoneMatch) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.GET);
        request.RequestFormat = DataFormat.Json;

        // verify required params are set
        if (studentUniqueId == null || programType == null || programEducationOrganizationId == null || beginDate == null || programName == null || educationOrganizationId == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        if (studentUniqueId != null){
          request.AddParameter("studentUniqueId", studentUniqueId);
		}
        if (programType != null){
          request.AddParameter("programType", programType);
		}
        if (programEducationOrganizationId != null){
          request.AddParameter("programEducationOrganizationId", programEducationOrganizationId);
		}
        if (beginDate != null){
          request.AddParameter("beginDate", beginDate);
		}
        if (programName != null){
          request.AddParameter("programName", programName);
		}
        if (educationOrganizationId != null){
          request.AddParameter("educationOrganizationId", educationOrganizationId);
		}
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<StudentSpecialEducationProgramAssociation>(request);   
      }
      /// <summary>
      /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
      /// </summary>
      /// <param name="body">The JSON representation of the &quot;studentSpecialEducationProgramAssociation&quot; resource to be created or updated.</param>
      /// <returns></returns>
      public IRestResponse PostStudentSpecialEducationProgramAssociations(StudentSpecialEducationProgramAssociation body) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations", Method.POST);
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
      public IRestResponse<StudentSpecialEducationProgramAssociation> GetStudentSpecialEducationProgramAssociationsById(string id, string IfNoneMatch) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.GET);
        request.RequestFormat = DataFormat.Json;

        request.AddUrlSegment("id", id);
        // verify required params are set
        if (id == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<StudentSpecialEducationProgramAssociation>(request);   
      }
      /// <summary>
      /// Updates an existing resource based on the resource identifier. The PUT operation is used to update an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found and will not be created).  Additionally, natural key values cannot be changed using this operation, and will be not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
      /// </summary>
      /// <param name="id">A resource identifier specifying the resource to be updated.</param>
      /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
      /// <param name="body">The JSON representation of the &quot;studentSpecialEducationProgramAssociation&quot; resource to be updated.</param>
      /// <returns></returns>
      public IRestResponse PutStudentSpecialEducationProgramAssociation(string id, string IfMatch, StudentSpecialEducationProgramAssociation body) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.PUT);
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
      public IRestResponse DeleteStudentSpecialEducationProgramAssociationById(string id, string IfMatch) {
        var request = new RestRequest("/studentSpecialEducationProgramAssociations/{id}", Method.DELETE);
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
