using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xunit.Gherkin.PilotProject
{
    public class Calculator
    {
        public int firstNumber;
        public int secondNumber;
        public int Result;
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
        public void SetFirstNumber(int firstNumber)
        {
            this.firstNumber = firstNumber;
        }
        public void SetSecondNumber(int secondNumber)
        {
            this.secondNumber = secondNumber; 
        }
        public void calcEscalation()
        {
            Result = firstNumber * (100+secondNumber);
        }
    }
}
