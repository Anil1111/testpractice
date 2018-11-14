using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
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
            // Test the RIGHT thing like this trustworthy test.
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

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit() {
            var result = _math.GetOddNumbers(5);

            // Too general
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            // EquivalentTo() checks the existence of each of the items,
            // and doesn't care about the order.
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}