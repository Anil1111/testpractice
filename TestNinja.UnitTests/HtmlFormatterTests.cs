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

            // Too specific, but better than too general.
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            // Too general.
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

            // My solution.
            Assert.That(result, Is.EqualTo($"<strong>{src}</strong>"));
        }
    }
}