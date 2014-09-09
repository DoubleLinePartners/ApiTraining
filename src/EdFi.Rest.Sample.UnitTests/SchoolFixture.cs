using System;
using EdFi.Rest.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Getting_Schools : BaseFixture
    {
        [TestMethod]
        public void Should_Get_Multiple()
        {
            var api = new SchoolsApi(GetClientWithSchoolYear());
            var response = api.GetSchoolsAll(null, null);

            Assert.IsTrue(response.Data.Count > 20);
        }
    }
}
