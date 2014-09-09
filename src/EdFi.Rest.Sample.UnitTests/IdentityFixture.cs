using System;
using EdFi.Rest.Api;
using EdFi.Rest.Client.Sdk.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Creating_And_Getting_Identities : BaseFixture
    {
        [TestMethod]
        public void Should_Retrieve_Original_Data()
        {
            var identitiesApi = new IdentitiesApi(GetClientWithoutSchoolYear());
            var identity = NewRandomIdentity();

            var postResponse = identitiesApi.PostIdentity(identity);

            Assert.IsFalse(string.IsNullOrEmpty(postResponse.Data.uniqueId));

            var getResponse = identitiesApi.GetIdentitiesById(postResponse.Data.uniqueId);

            Assert.AreEqual(identity.familyNames, getResponse.Data.familyNames);
            Assert.AreEqual(identity.givenNames, getResponse.Data.givenNames);
            Assert.AreEqual(identity.birthGender, getResponse.Data.birthGender);
            Assert.AreEqual(DateTime.Parse(identity.birthDate), DateTime.Parse(getResponse.Data.birthDate));
            Assert.IsTrue(getResponse.Data.weight > 0);
            Assert.AreEqual(identity.birthGender, getResponse.Data.birthGender);
        }
    }

    [TestClass]
    public class When_Getting_Identities_By_Example : BaseFixture
    {
        [TestMethod]
        public void Should_Retrieve_Results_With_Weight()
        {
            var identitiesApi = new IdentitiesApi(GetClientWithoutSchoolYear());
            var getResponse = identitiesApi.GetIdentityByExample(new Identity
            {
                birthGender = "Female",
                familyNames = "Sue",
                givenNames = "Sally"
            });

            Assert.IsTrue(getResponse.Data.Count > 0);

            foreach (var identity in getResponse.Data)
            {
                Assert.IsTrue(identity.weight > 0);
            }
        }
    }
}

public interface IIdentity
{
    string UniqueId { get; set; }
    Gender? BirthGender { get; set; }
    DateTime? BirthDate { get; set; }
    string FamilyNames { get; set; }
    string GivenNames { get; set; }
    double Weight { get; set; }
    IIdentifier[] Identifiers { get; set; }
}

public enum Gender
{
    Male,
    Female
}

public interface IIdentifier
{
    int IdentifierTypeId { get; set; }
    string Value { get; set; }
}

public interface IUniqueIdentity
{
    IIdentity Get(string uniqueId);
    IIdentity[] Get(IIdentity identity);
    IIdentity Post(IIdentity identity);
}

