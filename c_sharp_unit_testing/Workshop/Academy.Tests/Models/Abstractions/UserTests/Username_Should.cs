using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models.Abstractions;
using Moq;
using Academy.Models;

namespace Academy.Tests.Models.Abstractions.UserTests
{
    [TestFixture]
    class Username_Should
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("aa")]
        [TestCase("very long username")]
        public void ThrowArgumenException_WhenPassedValueIsInvalid(string username)
        {
            //arrange
            var userMock = new Mock<User>("goshko");
            //act and asser
            Assert.Throws<ArgumentException>(() => userMock.Object.Username = username);
        }
        [Test]
        public void NotThrow_WhenPassedValidValue()
        {
            //arrange
            var userMock = new Mock<User>("goshko");
            var throwEx = false;
            //act
            try
            {
                userMock.Object.Username = "karakolio";
            }
            catch (Exception)
            {
                throwEx = true;
            }
            finally
            {
                //assert
                Assert.False(throwEx);
            }
        }
        [Test]
        public void CorrectlyAssign_PassedValue()
        {
            //arrange
            var userMock = new Mock<User>("goshko");
            //act
            userMock.Object.Username = "mincho";
            //asser
            Assert.AreEqual("mincho", userMock.Object.Username);
        }
    }
}
