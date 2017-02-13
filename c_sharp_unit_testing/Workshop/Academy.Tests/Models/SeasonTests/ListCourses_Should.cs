using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Academy.Models;
using Academy.Models.Contracts;
using NUnit.Framework;
using Academy.Models.Enums;

namespace Academy.Tests.Models.SeasonTests
{
    [TestFixture]
    class ListCourses_Should
    {
        [Test]
        public void ReturnAListOfCourses_WhenCalled()
        {
            //arrange
            var seasonStub = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var courseMock = new Mock<ICourse>();
            courseMock.Setup(x => x.ToString());
            //act
            seasonStub.Courses.Add(courseMock.Object);
            seasonStub.ListCourses();
            //assert
            courseMock.Verify(x => x.ToString(), Times.AtLeastOnce);
        }
        [Test]
        public void ReturnNoCoursesMessage_WhenCoursesListIsEmpty()
        {
            //arrange
            var seasonStub = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var result = "";
            //act
            result = seasonStub.ListCourses();
            //assert
            StringAssert.Contains("There are no courses in this season!", result);
        }
    }
}
