using NUnit.Framework;

namespace TestNinja.Fundamentals.Tests {
    [TestFixture()]
    public class FizzBuzzTests {

        [Test()]
        public void GetOutput_WhenDivisibleBy3And5_ReturnFizzBuzz() {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test()]
        public void GetOutput_WhenDivisibleBy3_ReturnFizz() {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test()]
        public void GetOutput_WhenDivisibleBy3_ReturnBuzz() {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test()]
        public void GetOutput_WhenDivisibleByNot3Nor5_ReturnBuzz() {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}