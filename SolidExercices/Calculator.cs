using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            string[] nombres = operation.Split('+');
            double result = Convert.ToDouble(nombres[0]);
            for (int i = 1; i < nombres.Length; i++)
            {
                result += Convert.ToDouble(nombres[i]);
            }
            return result;
        }
    }
}