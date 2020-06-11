using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;


namespace RestAPITest
{
    [TestFixture]
    public class Tests
    {
        private RestClient client;
        private RestRequest request;

        [SetUp]
        public void Setup()
        {
            client = new RestClient("http://jsonplaceholder.typicode.com");
            request = new RestRequest("users");
        }

        [Test]
        public void TestGet_WhenSendUsers_ShouldReturnOk()
        {
            request.Method = Method.GET;
            var response = client.Execute<List<Users>>(request);
            Assert.AreEqual(true, response.IsSuccessful);
            Assert.AreNotEqual(0, response.Data.Count);

        }
    }
}
