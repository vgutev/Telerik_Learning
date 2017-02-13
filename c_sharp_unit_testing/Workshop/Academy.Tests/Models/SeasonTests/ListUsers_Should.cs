using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Academy.Models;
using Academy.Models.Enums;
using Academy.Models.Contracts;

namespace Academy.Tests.Models.SeasonTests
{
    [TestFixture]
    class ListUsers_Should
    {
        [Test]
        public void ReturnAListOfUsers_WhenCalled()
        {
            //arrange
            var seasonStub = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var studentMock = new Mock<IStudent>();
            studentMock.Setup(x => x.ToString());
            //act
            seasonStub.Students.Add(studentMock.Object);
            seasonStub.ListUsers();
            //assert
            studentMock.Verify(x => x.ToString(), Times.AtLeastOnce);
        }
        [Test]
        public void ReturnNoUsersMessage_WhenStudentsAndTrainersListsAreEmpty()
        {
            //arrange
            var seasonStub = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var result = "";
            //act
            result = seasonStub.ListUsers();
            //assert
            StringAssert.Contains("There are no users in this season!", result);
        }
    }
}
