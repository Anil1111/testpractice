using NUnit.Framework;
using TestNinja.Fundamentals;

namespace MathTests {
    [TestFixture]
    public class MathTests {

        private Math _math;

        // Set Up
        [SetUp]
        public void SetUp() {
            _math = new Math();
        }

        // Tear Down


        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments() {
            /* Tripple A convention */
            // 1. Arrage
            // 2. Act
            var result = _math.Add(1, 2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument() {
            // In each test, you should start with a fresh, clean state; new object!
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsTheSecondArgument() {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArgument() {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}