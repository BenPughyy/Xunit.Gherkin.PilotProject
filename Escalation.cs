using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("Escalation.feature")]
    public class Escalation : Feature
    {
        public Calculator escCalc = new Calculator();

        [Given(@"I chose {} as first number")]
        public void I_chose_first_number(double firstNumber)
        {
            escCalc.SetFirstNumber(firstNumber);
        }

        [And(@"I chose {} as escalation value")]
        public void I_chose_second_number(double secondNumber)
        {
            escCalc.SetSecondNumber(secondNumber);
        }

        [When(@"I press calculate")]
        public void I_press_calc()
        {
            escCalc.calcEscalation();
        }

        [Then(@"the result should return {} on the screen")]
        public void The_result_should_be_z_on_the_screen(double expectedResult)
        {
            var actualResult = escCalc.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
