using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("Escalation.feature")]
    public class Escalation : Feature
    {
        public Calculator escCalc = new Calculator();

        [Given(@"I chose (\d+) as first number")]
        public void I_chose_first_number(int firstNumber)
        {
            escCalc.SetFirstNumber(firstNumber);
        }

        [And(@"I chose (\d+) as escalation value")]
        public void I_chose_second_number(int secondNumber)
        {
            escCalc.SetSecondNumber(secondNumber);
        }

        [When(@"I press calculate")]
        public void I_press_calc()
        {
            escCalc.calcEscalation();
        }

        [Then(@"the result should return (\d+) on the screen")]
        public void The_result_should_be_z_on_the_screen(int expectedResult)
        {
            var actualResult = escCalc.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
