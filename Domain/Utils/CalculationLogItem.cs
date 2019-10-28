namespace AsyncExamples.Domain.Utils
{
    public class CalculationLogItem
    {
        public int Number { get; internal set; }
        public string Name { get; internal set; }
        public long Result { get; internal set; }
        public double MilliSeconds { get; internal set; }
        public int ThreadId { get; internal set; }
    }
}