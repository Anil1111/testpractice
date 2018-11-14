using NUnit.Framework;
using NUnit.Framework.Internal;
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
    }
}
