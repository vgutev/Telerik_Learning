using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Commands.Adding;
using NUnit.Framework;
using Moq;
using Academy.Core.Contracts;

namespace Academy.Tests.Commands.Adding.AddStudentToSeasonCommandTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void ThrowArgumentException_WhenPassedProviderIsNull()
        {
            // Arrange
            var engineMock = new Mock<IEngine>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock.Object));
        }
    }
}
