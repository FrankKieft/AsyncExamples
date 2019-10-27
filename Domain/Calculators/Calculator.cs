using System;
using System.Threading.Tasks;
using AsyncExamples.Domain.Utils;

namespace AsyncExamples.Domain.Calculators
{
    public abstract class Calculator
    {
        public abstract void Calculate(int x, CalculationLog log);

        public async Task AsyncCalculate(int x, CalculationLog log)
        {
            Calculate(x, log);
        }

        public Task TaskCalculate(int x, CalculationLog log)
        {
            return new Task(() => Calculate(x, log));
        }
    }
}
