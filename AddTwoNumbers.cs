using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("AddTwoNumbers.feature")]
    public class AddTwoNumbers : Feature
    {
        public Calculator _calculator = new Calculator();

        [Given(@"I chose (\d+) as first number")]
        public void I_chose_first_number(int firstNumber)
        {
            _calculator.SetFirstNumber(firstNumber);
        }

        [And(@"I chose (\d+) as second number")]
        public void I_chose_second_number(int secondNumber)
        {
            _calculator.SetSecondNumber(secondNumber);
        }

        [When(@"I press add")]
        public void I_press_add()
        {
            _calculator.AddNumbers();
        }

        [Then(@"the result should be (\d+) on the screen")]
        public void The_result_should_be_z_on_the_screen(int expectedResult)
        {
            var actualResult = _calculator.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}