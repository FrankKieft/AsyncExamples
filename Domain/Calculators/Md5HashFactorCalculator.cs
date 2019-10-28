using AsyncExamples.Domain.Utils;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace AsyncExamples.Domain.Calculators
{
    public class Md5HashFactorCalculator : Calculator
    {
        public Md5HashFactorCalculator(int number):base(number)
        {
        }

        public override void Calculate(int x, CalculationLog log)
        {
            var t = DateTime.Now;
            var y = 0;

            using (MD5 md5 = MD5.Create())
            {
                while (!IsFactor(x, ++y, md5))
                {
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

        private bool IsFactor(int x, int y, MD5 md5)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes($"({x},{y})");
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().EndsWith("00000");
        }
    }
}
