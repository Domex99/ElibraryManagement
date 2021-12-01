using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using WebApplication3;
using WebApplication3.models;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IUserRepo> mockRepo = new Mock<IUserRepo>();

            String name = "dome123";
            mockRepo.Setup(repo => repo.checkMemberExists(name)).Returns(true);

            UserService userService = new UserService(mockRepo.Object);

          

            Assert.IsTrue(userService.checkMemberExists("dome123"));
        }
    }
}
