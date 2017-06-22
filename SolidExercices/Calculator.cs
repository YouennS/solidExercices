using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            Operation op = new Operation(operation);

            return op.Calculate();
        }
    }
}