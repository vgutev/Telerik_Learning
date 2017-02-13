using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void CorrectlyAssign_Name()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act and assert
            Assert.AreEqual("cSharp", courseStub.Name);
        }
        [Test]
        public void CorrectlyAssign_LecturesPerWeek()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act and assert
            Assert.AreEqual(5, courseStub.LecturesPerWeek);
        }
        [Test]
        public void CorrectlyAssign_StartingDate()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, new DateTime(2017, 2, 13), DateTime.Now.AddDays(17));
            //act and assert
            Assert.AreEqual(new DateTime(2017, 2, 13), courseStub.StartingDate);
        }
        [Test]
        public void CorrectlyAssign_EndingDate()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, new DateTime(2017, 2, 13).AddDays(17));
            //act and assert
            Assert.AreEqual(new DateTime(2017, 2, 13).AddDays(17), courseStub.EndingDate);
        }
    }
}
