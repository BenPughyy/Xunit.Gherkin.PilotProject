namespace Xunit.Gherkin.PilotProject
{
    public class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double Result;
        public DateTime startDate;
        public DateTime endDate;
        public int escalationYears;
        public double interestRate;
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
        public void calcLinearEscalation()
        {
            Result = firstNumber + (firstNumber * (secondNumber/100));
        }
        public void SetEscalationYears(int escalationYears)
        {
            this.escalationYears = escalationYears;
        }
        public void SetInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }
        public void calcCompoundEscalation()
        {
            Result = (double)Convert.ToDecimal(firstNumber * Math.Pow(1 + (interestRate / 100),
                escalationYears));
        }
        public void SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public void SetEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public void calcPeriodLengthInDays()
        {
            Result = (endDate - startDate).Days;
        }
    }
}
