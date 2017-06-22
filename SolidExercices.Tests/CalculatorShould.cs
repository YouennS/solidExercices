using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculeSomme()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculeSoustraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4,3-2,2");
            Check.That(result).IsEqualTo(2.1);
        }

        [Test]
        public void CalculeMultiplication()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3*4");
            Check.That(result).IsEqualTo(12);
        }

        [Test]
        public void CalculeDivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("15/3");
            Check.That(result).IsEqualTo(5);
        }
    }
}
