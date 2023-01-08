using Microsoft.AspNetCore.Mvc.Testing;
using dotnet_mvc_notebooks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net;

namespace dotnet_mvc_notebooks.test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public async Task TEST_GoToPgae_Home()
        {
            await using var application = new WebApplicationFactory<Program>();
            var httpClient = application.CreateDefaultClient();

            var request = await httpClient.GetAsync("/home");
            var resp = await request.Content.ReadAsStringAsync();

            Assert.AreEqual(HttpStatusCode.OK, request.StatusCode);
        }

        [DataTestMethod]
        [DataRow("Welcome")]
        [DataRow("Welcome++")]
        public async Task TEST_Find_Text(string title)
        {
            await using var application = new WebApplicationFactory<Program>();
            var httpClient = application.CreateDefaultClient();

            var request = await httpClient.GetAsync("/home");
            var resp = await request.Content.ReadAsStringAsync();
            var contentString = resp.ToString();

            StringAssert.Contains(contentString, title);

        }
    }
}