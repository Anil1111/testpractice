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
        // Disabling the test is the better approach than commenting it out or deleting it.
        //[Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments() {
            /* Tripple A convention */
            // 1. Arrage
            // 2. Act
            var result = _math.Add(1, 2);

            // Example of NOT trustworthy test codes (Do NOT test like this!)
            Assert.That(_math, Is.Not.Null);

            // 3. Assert
            // Test the right thing like this trustworthy test.
            Assert.That(result, Is.EqualTo(3));
        }

        // Generalized Test
        // If there's none, "No arguments were provided" occurs.
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int expectedResult) {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}