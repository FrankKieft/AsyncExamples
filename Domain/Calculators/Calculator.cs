using System.Threading.Tasks;
using AsyncExamples.Domain.Utils;

namespace AsyncExamples.Domain.Calculators
{
    public abstract class Calculator
    {
        public Calculator(int number)
        {
            Number = number;
        }

        public abstract void Calculate(int x, CalculationLog log);

        public async Task AsyncCalculate(int x, CalculationLog log)
        {
            Calculate(x, log);
        }

        public int Number { get; }
    }
}
