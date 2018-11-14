using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace TestPractice.Fundamentals.UnitTests {
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

            // Learn more about C#'s lambda expression
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

            // This Exception type check can be helpful.
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent() {

            var id = Guid.Empty;

            // Learn more about C#'s delegate and event
            logger.ErrorLogged += (sender, guid) => { id = guid; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        //[Test]
        //[Ignore("Don't test the implementation details!")]
        //public void OnErrorLogged_WhenCalled_RaiseEvent() {

        //    // As you refactor the implementation details,
        //    // It broke up all the tests about them.
        //    // So, DO NOT test the implementation details!
        //    //logger.OnErrorLogged(Guid.NewGuid());

        //    Assert.That(true);
        //}
    }
}