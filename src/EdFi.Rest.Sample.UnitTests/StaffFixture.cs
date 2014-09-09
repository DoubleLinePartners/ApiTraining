using System;
using System.Net;
using EdFi.Rest.Api;
using EdFi.Rest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Creating_And_Getting_A_StaffSchoolAssociation : BaseFixture
    {
        [TestMethod]
        public void Should_Succeed()
        {
            var clientWithSchoolYear = GetClientWithSchoolYear();
            var identity = NewRandomIdentity();
            var identityApi = new IdentitiesApi(GetClientWithoutSchoolYear());
            var postIdentityResponse = identityApi.PostIdentity(identity);
            var staffsApi = new StaffsApi(clientWithSchoolYear);
            var staff = new Staff
                              {
                                  staffUniqueId = postIdentityResponse.Data.uniqueId,
                                  firstName = identity.givenNames,
                                  lastSurname = identity.familyNames,
                                  sexType = identity.birthGender
                              };

            // Create
            var postResponse = staffsApi.PostStaffs(staff);

            Assert.AreEqual(HttpStatusCode.Created, postResponse.StatusCode);

            var staffSchoolAssociationsApi = new StaffSchoolAssociationsApi(clientWithSchoolYear);
            var staffSchoolAssociationsResponse = staffSchoolAssociationsApi.PostStaffSchoolAssociations(new StaffSchoolAssociation
            {
                staffReference = new StaffReference() { staffUniqueId = postIdentityResponse.Data.uniqueId },
                schoolReference = new SchoolReference { schoolId = SchoolId },
                programAssignmentDescriptor = ProgramAssignmentDescriptor
            });

            Assert.AreEqual(HttpStatusCode.Created, staffSchoolAssociationsResponse.StatusCode);

            // Update
            postResponse = staffsApi.PostStaffs(staff);

            Assert.AreEqual(HttpStatusCode.OK, postResponse.StatusCode);

            var getResponse = staffsApi.GetStaffByKey(postIdentityResponse.Data.uniqueId, string.Empty);

            Assert.AreEqual(HttpStatusCode.OK, getResponse.StatusCode);
        }
    }
}
