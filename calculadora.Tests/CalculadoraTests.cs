using NUnit.Framework;

namespace calculadora.Tests
{
    public class CalculadoraTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,2,4)]
        [TestCase(6, 2, 8)]
        [TestCase(25, 25, 50)]
        [TestCase(100, 100, 200)]
        [TestCase(5, 2, 7)]
        public void Calculadora_Sum_CorrectAnswers(int a, int b, int expectedResult)
        {
            int result = Calculadora.suma(a, b);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        [TestCase(2, 2, 2)]
        [TestCase(6, 2, 3)]
        [TestCase(25, 25, 0)]
        [TestCase(100, 100, 20)]
        [TestCase(5, 2, 75)]
        public void Calculadora_Sum_IncorrectAnswers(int a, int b, int expectedResult)
        {
            int result = Calculadora.suma(a, b);
            Assert.AreNotEqual(expectedResult, result);
        }
    }
}