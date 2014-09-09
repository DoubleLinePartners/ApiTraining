using System;
using EdFi.Rest.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Getting_GradeLevelDescriptors : BaseFixture
    {
        [TestMethod]
        public void Should_Get_Multiple()
        {
            var api = new GradeLevelDescriptorsApi(GetClientWithSchoolYear());
            var response = api.GetGradeLevelDescriptorsAll(null, null);

            Assert.IsTrue(response.Data.Count > 10);
        }
    }
}
