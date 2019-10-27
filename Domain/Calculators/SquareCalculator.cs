using System;
using System.Threading;
using AsyncExamples.Domain.Utils;

namespace AsyncExamples.Domain.Calculators
{
    public class SquareCalculator : Calculator
    {
        public override void Calculate(int x, CalculationLog log)
        {
            var t = DateTime.Now;
            var y = x * x;

            log.Items.Add(new CalculationLogItem
            {
                Result = y,
                Name = GetType().Name,
                MilliSeconds = (DateTime.Now - t).TotalMilliseconds,
                Thread = Thread.CurrentThread.Name
            });
        }
    }
}
