using EdFi.Rest.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdFi.Rest.Sample.UnitTests
{
    [TestClass]
    public class When_Getting_SchoolCategoryTypes : BaseFixture
    {
        [TestMethod]
        public void Should_Get_Multiple()
        {
            var api = new SchoolCategoryTypesApi(GetClientWithSchoolYear());
            var response = api.GetSchoolCategoryTypesAll(null, null);

            Assert.IsTrue(response.Data.Count > 5);
        }
    }
}
