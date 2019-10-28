using System;
using System.Threading;
using AsyncExamples.Domain.Utils;

namespace AsyncExamples.Domain.Calculators
{
    public class PrimeCalculator : Calculator
    {
        public PrimeCalculator(int number) : base(number)
        {
        }
        
        public override void Calculate(int x, CalculationLog log)
        {
            var t = DateTime.Now;
            var count = 0;
            var y = 1;
            while(count<x)
            {
                if(IsPrime(++y))
                {
                    count++;
                }
            }

            log.Items.Add(new CalculationLogItem
            {
                Number = Number,
                Result = y,
                Name = GetType().Name,
                MilliSeconds = (DateTime.Now - t).TotalMilliseconds,
                ThreadId = Thread.CurrentThread.ManagedThreadId
            });
        }
        
        private bool IsPrime(int x)
        {
            var max = Convert.ToInt32(Math.Sqrt(x));

            for (var i = 2; i <= max; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
