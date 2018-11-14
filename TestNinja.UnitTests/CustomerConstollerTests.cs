using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    /// <summary>
    /// Summary description for CustomerConstollerTests
    /// </summary>
    [TestFixture]
    public class CustomerConstollerTests {

        private CustomerController _controller;

        [SetUp]
        public void SetUp() {
            _controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound() {
            var result = _controller.GetCustomer(0);

            // Is NotFound?
            Assert.That(result, Is.TypeOf<NotFound>());

            // Is NotFound or one of its derivatives?
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk() {
            var result = _controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
