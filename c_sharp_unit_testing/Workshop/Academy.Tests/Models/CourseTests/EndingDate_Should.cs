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
    class EndingDate_Should
    {
        [Test]
        public void CorrectlyAssign_PassedValue()
        {
            //arrange
            var courseStub = new Course("cSharp", 5, DateTime.Now, DateTime.Now.AddDays(17));
            //act
            courseStub.EndingDate = new DateTime(2017, 08, 08);
            //assert
            Assert.AreEqual(new DateTime(2017, 08, 08), courseStub.EndingDate);
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
                courseStub.EndingDate = new DateTime(2017, 08, 08);
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
