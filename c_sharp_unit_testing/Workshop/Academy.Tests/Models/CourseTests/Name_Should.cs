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
    class Name_Should
    {
        [Test]
        public void ThrowArgumentException_WhenPassedValueIsInvalid()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act and assert
            Assert.Throws<ArgumentException>(() => courseStub.Name = "");
        }

        [Test]
        public void NotThrow_WhenPassedIsValid()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            var throwsEx = false;
            //act
            try
            {
                courseStub.Name = "Java";
            }
            catch (Exception)
            {
                throwsEx = true;
            }
            finally
            {
                //assert
                Assert.False(throwsEx);
            }
        }

        [Test]
        public void CorrectlyAssign_WhenPassedValue()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act
            courseStub.Name = "Java";
            //assert
            Assert.AreEqual("Java", courseStub.Name);
        }
    }
}
