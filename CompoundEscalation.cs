using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("CompoundEscalation.feature")]
    public class CompoundEscalation : Feature
    {
        public Calculator compEsc = new Calculator();

        [Given(@"I chose {} as first number")]
        public void I_chose_first_number(double firstNumber)
        {
            compEsc.SetFirstNumber(firstNumber);
        }

        [And(@"I chose {} as escalation value")]
        public void I_chose_interest_rate(double interestRate)
        {
            compEsc.SetInterestRate(interestRate);
        }

        [And(@"I chose {int} as the number of Escalation Years")]
        public void I_chose_escalation_years(int escalationYears)
        {
            compEsc.SetEscalationYears(escalationYears);
        }

        [When(@"I press calculate")]
        public void I_press_calc()
        {
            compEsc.calcCompoundEscalation();
        }

        [Then(@"the result should return {} on the screen")]
        public void The_result_should_be_z_on_the_screen(double expectedResult)
        {
            var actualResult = compEsc.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
