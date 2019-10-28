using System;
using System.Threading;
using AsyncExamples.Domain.Utils;

namespace AsyncExamples.Domain.Calculators
{
    public class SquareCalculator : Calculator
    {
        public SquareCalculator(int number) : base(number)
        {
        }

        public override void Calculate(int x, CalculationLog log)
        {
            var t = DateTime.Now;
            var y = x * x;

            log.Items.Add(new CalculationLogItem
            {
                Number = Number,
                Result = y,
                Name = GetType().Name,
                MilliSeconds = (DateTime.Now - t).TotalMilliseconds,
                ThreadId = Thread.CurrentThread.ManagedThreadId
            });
        }
    }
}
