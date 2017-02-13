using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Moq;
using Academy.Models.Contracts;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    class ToString_Should
    {
        [Test]
        public void ReturnPassedData_AListOfLectures()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            var lectureMock = new Mock<ILecture>();
            lectureMock.Setup(x => x.ToString());
            courseStub.Lectures.Add(lectureMock.Object);
            //act
            courseStub.ToString();
            //assert
            lectureMock.Verify(x => x.ToString(), Times.Once);
        }
        [Test]
        public void ReturnNoLecturesMessage_WhenLecturesListIsEmpty()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            var result = "";
            //act
            result = courseStub.ToString();
            //assert
            StringAssert.Contains("* There are no lectures in this course!", result);
        }
    }
}
