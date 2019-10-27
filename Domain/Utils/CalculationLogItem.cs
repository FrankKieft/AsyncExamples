namespace AsyncExamples.Domain.Utils
{
    public class CalculationLogItem
    {
        public string Name { get; internal set; }
        public long Result { get; internal set; }
        public double MilliSeconds { get; internal set; }
        public string Thread { get; internal set; }
    }
}