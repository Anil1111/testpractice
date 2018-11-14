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
    }
}