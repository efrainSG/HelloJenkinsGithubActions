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

        [Test]
        public void Test1()
        {
            controller = new HelloJenkinsController(businessLogic);

            var response = controller.getHello("Efra");

            Console.WriteLine(response);
            Assert.AreEqual("Hello, Efra.", response);
        }
    }
}