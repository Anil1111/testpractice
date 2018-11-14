using NUnit.Framework;
using TestNinja.Fundamentals;

namespace MathTests {
    [TestFixture]
    public class MathTests {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments() {
            /* Tripple A convention */
            // 1. Arrage
            var m = new Math();

            // 2. Act
            var result = m.Add(1, 2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument() {
            // In each test, you should start with a fresh, clean state; new object!
            var m = new Math();
            var result = m.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsTheSecondArgument() {
            var m = new Math();
            var result = m.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArgument() {
            var m = new Math();
            var result = m.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}