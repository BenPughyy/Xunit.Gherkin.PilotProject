namespace Xunit.Gherkin.PilotProject
{
    public class ResourceObject
    {
        double useEventValue;
        int frequency;
        int occurrence;
        public double useEventPeriodValue;

        public ResourceObject(double useEventValue, int occurrence, int frequency)
        {
            this.useEventValue = useEventValue;
            this.occurrence = occurrence;
            this.frequency = frequency;
        }
        public ResourceObject()
        {
            this.useEventValue = 0;
            this.occurrence = 0;
            this.frequency = 0;
        }
        public void SetUseEventValue(double useEventValue)
        {
            this.useEventValue = useEventValue;
        }
        public void SetOccurrence(int occurrence)
        {
            this.occurrence = occurrence;
        }
        public void SetFrequency(int frequency)
        {
            this.frequency = frequency;
        }
        public double CalcUseEventPeriod()
        {
            return useEventPeriodValue = (useEventValue * occurrence) / frequency;
        }
        public double CalcReportTotal(int numberOfPeriods)
        {
            return useEventPeriodValue * numberOfPeriods;
        }
    }
}
