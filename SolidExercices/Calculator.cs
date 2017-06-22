using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            double result;
            string[] nombres = operation.Split('+');
            result = Convert.ToDouble(nombres[0]);
            for (int i = 1; i < nombres.Length; i++)
            {
                result += Convert.ToDouble(nombres[i]);
            }
            return result;
        }
    }
}