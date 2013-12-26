using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Howzzzat.Controllers;

namespace Howzzzat.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Should_log_when_executed()
        {
            //Arrange
            var logger = new FakeLogger();
            HelloController controller = new HelloController(logger);

            //Act 
            controller.SayHello();

            //Assert
            Assert.IsNotNull(logger.LogResult);
        }
    }
}
