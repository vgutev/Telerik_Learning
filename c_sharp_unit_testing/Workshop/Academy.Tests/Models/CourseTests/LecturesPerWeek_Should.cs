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
    class LecturesPerWeek_Should
    {
        [Test]
        public void ThrowArgumentException_WhenPassedValueIsInvalid()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act and assert
            Assert.Throws<ArgumentException>(() => courseStub.LecturesPerWeek = 12);
        }
        [Test]
        public void NotThrow_WhenPassedValueIsValid()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            var throwEx = false;
            //act
            try
            {
                courseStub.LecturesPerWeek = 7;
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
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act
            courseStub.LecturesPerWeek = 3;
            //assert
            Assert.AreEqual(3, courseStub.LecturesPerWeek);
        }
    }
}
