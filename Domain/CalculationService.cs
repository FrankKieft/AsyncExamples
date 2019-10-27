using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncExamples.Domain
{
    public class CalculationService
    {
        private List<Calculator> _calculators;

        public CalculationService()
        {
            _calculators = new List<Calculator>
            {
                new Md5HashFactorCalculator(),
                new SquareCalculator(),
                new Sha256HashFactorCalculator(),
                new PrimeCalculator(),
                new Md5HashFactorCalculator(),
            };
        }

        public CalculationLog Calculate(int x)
        {
            var t = DateTime.Now;
            var log = new CalculationLog();
            log.StartThreadId = Thread.CurrentThread.ManagedThreadId;

            _calculators.ForEach(c => c.Calculate(x, log));

            log.MilliSeconds = (DateTime.Now - t).TotalMilliseconds;
            log.EndThreadId = Thread.CurrentThread.ManagedThreadId;
            return log;
        }

        public async Task<CalculationLog> AsyncCalculate(int x)
        {
            var t = DateTime.Now;
            var log = new CalculationLog();
            log.StartThreadId = Thread.CurrentThread.ManagedThreadId;

            foreach (var calculator in _calculators)
            {
                await calculator.AsyncCalculate(x, log);
            }

            log.MilliSeconds = (DateTime.Now - t).TotalMilliseconds;
            log.EndThreadId = Thread.CurrentThread.ManagedThreadId;
            return log;
        }

        public async Task<CalculationLog> AsyncWithTaskCalculate(int x)
        {
            var t = DateTime.Now;
            var log = new CalculationLog();
            log.StartThreadId = Thread.CurrentThread.ManagedThreadId;

            foreach (var calculator in _calculators)
            {
                await Task.Run(()=>calculator.Calculate(x, log));                
            }

            log.MilliSeconds = (DateTime.Now - t).TotalMilliseconds;
            log.EndThreadId = Thread.CurrentThread.ManagedThreadId;
            return log;
        }
    }
}
