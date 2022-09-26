using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{
    [FeatureFile("CalculatePeriods.feature")]
    public class CalculatePeriods : Feature
    {
        public Calculator periodCalc = new Calculator();

        [Given(@"I select {} as an start date")]
        public void I_select_first_date(DateTime startDate)
        {
            periodCalc.SetStartDate(startDate);
        }
        [And(@"I select {} as an end date")]
        public void I_select_end_date(DateTime endDate)
        {
            periodCalc.SetEndDate(endDate);
        }
        [When(@"I press calculate")]
        public void calculate()
        {
            periodCalc.calcPeriodLengthInDays();
        }
        [Then(@"the result should show (\d+) on the screen")]
        public void The_result_should_be_z_on_the_screen(int expectedResult)
        {
            var actualResult = periodCalc.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
