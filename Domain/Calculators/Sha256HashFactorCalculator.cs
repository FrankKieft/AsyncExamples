using AsyncExamples.Domain.Utils;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace AsyncExamples.Domain.Calculators
{
    public class Sha256HashFactorCalculator : Calculator
    {
        public override void Calculate(int x, CalculationLog log)
        {
            var t = DateTime.Now;
            var y = 0;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                while (!IsFactor(x, ++y, sha256Hash))
                {
                }
            }

            log.Items.Add(new CalculationLogItem
            {
                Result = y,
                Name = GetType().Name,
                MilliSeconds = (DateTime.Now - t).TotalMilliseconds,
                ThreadId = Thread.CurrentThread.ManagedThreadId
            });
        }

        private bool IsFactor(int x, int y, SHA256 sha256Hash)
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes($"({x},{y})"));

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString().EndsWith("00000");
        }
    }
}
