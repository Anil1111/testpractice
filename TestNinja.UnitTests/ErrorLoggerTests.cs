using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    /// <summary>
    /// Summary description for ErrorLoggerTests
    /// </summary>
    [TestFixture]
    public class ErrorLoggerTests {

        private ErrorLogger logger;

        [SetUp]
        public void SetUp() {
            logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() {

            // This is "Command" type of function not "Query".
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error) {

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

            // This Exception type check can be helpful.
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent() {

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, guid) => { id = guid; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}