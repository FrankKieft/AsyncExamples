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
    }
}
