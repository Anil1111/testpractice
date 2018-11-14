using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    /// <summary>
    /// Summary description for HtmlFormatterTests
    /// </summary>
    [TestFixture]
    public class HtmlFormatterTests {
        public HtmlFormatterTests() {
            //
            // TODO: Add constructor logic here
            //
        }

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElements() {
            var htmlFormatter = new HtmlFormatter();

            var src = "abc";
            var result = htmlFormatter.FormatAsBold(src);

            Assert.That(result, Is.EqualTo($"<strong>{src}</strong>"));

        }
    }
}