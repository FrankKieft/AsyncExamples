using System.Collections.Generic;

namespace AsyncExamples.Domain.Utils
{
    public class CalculationLog
    {
        public CalculationLog()
        {
            Items = new List<CalculationLogItem>();
        }

        public List<CalculationLogItem> Items { get; }
        public double MilliSeconds { get; internal set; }
        public int EndThreadId { get; internal set; }
        public int StartThreadId { get; internal set; }
    }
}
