using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        readonly char[] _operations={'+','-','*','/'};

        public double Calculate(string operation)
        {
            char typeOperation = FindTypeOperation(operation);
            string[] nombres = operation.Split(typeOperation);
            double result = Convert.ToDouble(nombres[0]);
            for (int i = 1; i < nombres.Length; i++)
            {
                switch (typeOperation)
                {
                    case '+':
                        result += Convert.ToDouble(nombres[i]);
                        break;
                    case '-':
                        result -= Convert.ToDouble(nombres[i]);
                        break;
                    case '*':
                        result *= Convert.ToDouble(nombres[i]);
                        break;
                    case '/':
                        result /= Convert.ToDouble(nombres[i]);
                        break;
                }
                
            }
            return result;
        }

        public char FindTypeOperation(string operation)
        {
            for (int i = 0; i < _operations.Length; i++)
            {
                if (operation.Contains(_operations[i]))
                    return _operations[i];
            }
            return '+';
        }
    }
}