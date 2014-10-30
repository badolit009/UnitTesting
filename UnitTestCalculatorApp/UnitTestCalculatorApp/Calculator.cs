using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCalculatorApp
{
   public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int multiply(int firstNumber, int secondNumber)
        {
            return firstNumber*secondNumber;
        }

        public double Devide(double firstNumber, double secondNumber)
        {
            return firstNumber/secondNumber;
        }
    }
}
