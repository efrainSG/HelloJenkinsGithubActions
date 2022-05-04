using HelloJenkins.BL;
using HelloJenkins.Controllers;
using NUnit.Framework;
using System;
using System.Net.Http;

namespace HelloJenkins.Testing
{
    public class Tests
    {
        private HttpClient client;
        private BusinessLogic businessLogic;
        private HelloJenkinsController controller;
        [SetUp]
        public void Setup()
        {
            businessLogic = new BusinessLogic();
            
        }

        [Test,
            TestCase("Efra"),
            TestCase("efra")]
        public void Test_Must_Pass(string name)
        {
            controller = new HelloJenkinsController(businessLogic);

            var response = controller.getHello(name);

            Console.WriteLine(response);
            Assert.AreEqual($"Hello, {name}.", response);
        }
    }
}