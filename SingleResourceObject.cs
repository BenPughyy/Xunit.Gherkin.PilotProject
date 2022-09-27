using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using Xunit.Gherkin.Quick;
using Feature = Xunit.Gherkin.Quick.Feature;

namespace Xunit.Gherkin.PilotProject
{

    [FeatureFile("SingleResourceObject.feature")]
    public class SingleResourceObject : Feature
    {
        ResourceObject testRO1 = new ResourceObject();

        [Given(@"I build one resource object")]
        public void CreateResourceObject()
        {
            testRO1.SetUseEventValue(10);
            testRO1.SetOccurrence(5);
            testRO1.SetFrequency(2);
        }

        [When(@"I press calculate")]
        public void CalcROOutputs()
        {
            testRO1.CalcUseEventPeriod();
            testRO1.CalcReportTotal(10);
        }
        [Then(@"it should display the correct outputs: {int} Period Value and {int} Report Total")]
        public void The_result_should_be_z_on_the_screen(int expectedResult1, int expectedresult2)
        {
            var actualResult1 = testRO1.CalcUseEventPeriod();
            var actualResult2 = testRO1.CalcReportTotal(10);

            Assert.Equal(expectedResult1, actualResult1);
            Assert.Equal(expectedresult2, actualResult2);
        }
    }
}
