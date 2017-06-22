using System;
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
            Check.That(result).IsEqualTo(Convert.ToDecimal(3.3));
        }

        [Test]
        public void CalculeSommes()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3+4+1,2");
            Check.That(result).IsEqualTo(Convert.ToDecimal(8.5));
        }

        [Test]
        public void CalculeSoustraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4-2");
            Check.That(result).IsEqualTo(2);
        }
        [Test]
        public void CalculeSoustractions()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4-2-1");
            Check.That(result).IsEqualTo(1);
        }

        [Test]
        public void CalculeMultiplication()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3*4");
            Check.That(result).IsEqualTo(12);
        }
        [Test]
        public void CalculeMultiplications()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3*4*10");
            Check.That(result).IsEqualTo(120);
        }

        [Test]
        public void CalculeDivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("15/3");
            Check.That(result).IsEqualTo(5);
        }
        [Test]
        public void CalculeDivisions()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("16/2/4");
            Check.That(result).IsEqualTo(2);
        }

        [Test]
        public void OperationInconnue()
        {
            var calculator = new Calculator();
            Check.ThatCode(() => calculator.Calculate("1!!:mo2,3")).Throws<Exception>().WithMessage("Type d'opération inconnu");
        }

        [Test]
        public void CalculatorTrainerTest()
        {
            CalculatorTrainer ct = new CalculatorTrainer();
            ct.Run();
        }
    }
}
