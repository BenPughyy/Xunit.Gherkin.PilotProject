using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xunit.Gherkin.PilotProject
{
    public class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double Result;
        public Calculator()
        {
            
        }
        public void AddNumbers()
        {
            Result = firstNumber + secondNumber;
        }
        public void MultiplyNumbers()
        {
            Result = firstNumber * secondNumber;
        }
        public void SetFirstNumber(double firstNumber)
        {
            this.firstNumber = firstNumber;
        }
        public void SetSecondNumber(double secondNumber)
        {
            this.secondNumber = secondNumber; 
        }
        public void calcEscalation()
        {
            Result = firstNumber + (firstNumber * (secondNumber/100));
        }
    }
}
