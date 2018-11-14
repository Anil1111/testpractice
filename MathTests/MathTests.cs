using NUnit.Framework;
using TestNinja.Fundamentals;

namespace MathTests {
    [TestFixture]
    public class MathTests {
        [Test]
        public void Add_AllPositiveValues_ReturnsAPlusB() {
            var m = new Math();

            var result = m.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
