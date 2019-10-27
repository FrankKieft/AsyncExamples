using AsyncExamples.Domain.Calculators;
using AsyncExamples.Domain.Utils;
using System.Collections.Generic;
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
                new HashFactorCalculator(),
                new PrimeCalculator(),
                new SquareCalculator()
            };
        }

        public CalculationLog Calculate(int x)
        {
            var log = new CalculationLog();

            _calculators.ForEach(c => c.Calculate(x, log));

            return log;
        }

        public async Task<CalculationLog> AsyncCalculate(int x)
        {
            var log = new CalculationLog();

            foreach(var calculator in _calculators)
            {
                await calculator.AsyncCalculate(x, log);
            }

            return log;
        }
    }
}
