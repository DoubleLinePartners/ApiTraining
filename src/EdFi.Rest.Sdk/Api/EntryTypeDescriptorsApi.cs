  using System;
  using System.Collections.Generic;
  using EdFi.Rest.Sdk;
  using EdFi.Rest.Models;
  using RestSharp;
  
  namespace EdFi.Rest.Api {
    public class EntryTypeDescriptorsApi {

      private readonly IRestClient client;

      public EntryTypeDescriptorsApi(IRestClient client)
      {
            this.client = client;
      }
      
      /// <summary>
      /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
      /// </summary>
      /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
      /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
      /// <returns></returns>
      public IRestResponse<List<EntryTypeDescriptor>> GetEntryTypeDescriptorsAll(int? offset, int? limit) {
        var request = new RestRequest("/entryTypeDescriptors", Method.GET);
        request.RequestFormat = DataFormat.Json;

        if (offset != null){
          request.AddParameter("offset", offset);
		}
        if (limit != null){
          request.AddParameter("limit", limit);
		}
        return client.Execute<List<EntryTypeDescriptor>>(request);   
      }
      /// <summary>
      /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
      /// </summary>
      /// <param name="entryTypeDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
      /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
      /// <returns></returns>
      public IRestResponse<EntryTypeDescriptor> GetEntryTypeDescriptorByKey(int? entryTypeDescriptorId, string IfNoneMatch) {
        var request = new RestRequest("/entryTypeDescriptors", Method.GET);
        request.RequestFormat = DataFormat.Json;

        // verify required params are set
        if (entryTypeDescriptorId == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        if (entryTypeDescriptorId != null){
          request.AddParameter("entryTypeDescriptorId", entryTypeDescriptorId);
		}
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<EntryTypeDescriptor>(request);   
      }
      /// <summary>
      /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
      /// </summary>
      /// <param name="body">The JSON representation of the &quot;entryTypeDescriptor&quot; resource to be created or updated.</param>
      /// <returns></returns>
      public IRestResponse PostEntryTypeDescriptors(EntryTypeDescriptor body) {
        var request = new RestRequest("/entryTypeDescriptors", Method.POST);
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
      public IRestResponse<EntryTypeDescriptor> GetEntryTypeDescriptorsById(string id, string IfNoneMatch) {
        var request = new RestRequest("/entryTypeDescriptors/{id}", Method.GET);
        request.RequestFormat = DataFormat.Json;

        request.AddUrlSegment("id", id);
        // verify required params are set
        if (id == null ) {
           throw new ArgumentException("API method call is missing required parameters");
        }
        request.AddHeader("If-None-Match", IfNoneMatch);
        return client.Execute<EntryTypeDescriptor>(request);   
      }
      /// <summary>
      /// Updates an existing resource based on the resource identifier. The PUT operation is used to update an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found and will not be created).  Additionally, natural key values cannot be changed using this operation, and will be not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
      /// </summary>
      /// <param name="id">A resource identifier specifying the resource to be updated.</param>
      /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
      /// <param name="body">The JSON representation of the &quot;entryTypeDescriptor&quot; resource to be updated.</param>
      /// <returns></returns>
      public IRestResponse PutEntryTypeDescriptor(string id, string IfMatch, EntryTypeDescriptor body) {
        var request = new RestRequest("/entryTypeDescriptors/{id}", Method.PUT);
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
      public IRestResponse DeleteEntryTypeDescriptorById(string id, string IfMatch) {
        var request = new RestRequest("/entryTypeDescriptors/{id}", Method.DELETE);
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
