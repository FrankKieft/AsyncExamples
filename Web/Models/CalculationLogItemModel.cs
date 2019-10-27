namespace AsyncExamples.Web.Models
{
    public class CalculationLogItemModel
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public long Result { get; set; }
        public double MilliSeconds { get; set; }
        public int ThreadId { get; set; }
    }
}