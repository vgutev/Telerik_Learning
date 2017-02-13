using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models.Abstractions;
using Academy.Models;
using Moq;

namespace Academy.Tests.Models.Abstractions.UserTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void CorrectlyAssign_Username()
        {
            //arrange
            var userStub = new Mock<User>("goshko");
            //asser
            Assert.AreEqual("goshko", userStub.Object.Username);
        }
    }
}
