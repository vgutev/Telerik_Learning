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
    class StartingDate_Should
    {
        [Test]
        public void CorrectlyAssign_PassedValue()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act
            courseStub.StartingDate = new DateTime(2017, 02, 02);
            //assert
            Assert.AreEqual(new DateTime(2017, 02, 02), courseStub.StartingDate);
        }
        [Test]
        public void NotThrowException_WhenPassedValueIsValid()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            var throwEx = false;
            //act
            try
            {
                courseStub.StartingDate = new DateTime(2017, 01, 02);
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
    }
}
