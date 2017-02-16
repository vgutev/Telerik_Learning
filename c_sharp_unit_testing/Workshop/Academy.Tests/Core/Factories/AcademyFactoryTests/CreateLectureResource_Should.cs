using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Core.Factories;
using Moq;
using Academy.Core.Contracts;

namespace Academy.Tests.Core.Factories.AcademyFactoryTests
{
    [TestFixture]
    class CreateLectureResource_Should
    {
        [Test]
        public void ThrowArgumenException_WhenPassedTypeIsInvalid()
        {
            //arrange
            var academyFactoryUnderTest = AcademyFactory.Instance;
            //act and assert
            Assert.Throws<ArgumentException>(() => academyFactoryUnderTest.CreateLectureResource("banan", "Banan", "htt:\\abv.bg"));
        }
    }
}
