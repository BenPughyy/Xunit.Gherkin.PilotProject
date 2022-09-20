using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("MultiplyTwoNumbers.feature")]
    public class MultiplyTwoNumbers : Feature
    {
        public Calculator timesCalculator = new Calculator();

        [Given(@"I chose (\d+) as first number")]
        public void I_chose_first_number(int firstNumber)
        {
            timesCalculator.SetFirstNumber(firstNumber);
        }

        [And(@"I chose (\d+) as second number")]
        public void I_chose_second_number(int secondNumber)
        {
            timesCalculator.SetSecondNumber(secondNumber);
        }

        [When(@"I press multiply")]
        public void I_press_multiply()
        {
            timesCalculator.MultiplyNumbers();
        }

        [Then(@"the result should be (\d+) on the screen")]
        public void The_result_should_be_z_on_the_screen(int expectedResult)
        {
            var actualResult = timesCalculator.Result;

            Assert.Equal(expectedResult, actualResult);
        }


    }
}
