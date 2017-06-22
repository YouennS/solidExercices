using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            char typeOperation = Operation.FindTypeOperation(operation);
            string[] nombres = operation.Split(typeOperation);
            
            return Operation.Calculate(nombres,typeOperation);
        }
    }
}