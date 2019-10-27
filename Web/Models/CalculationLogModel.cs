using AsyncExamples.Domain.Utils;
using System.Collections.Generic;
using System.Threading;

namespace AsyncExamples.Web.Models
{
    public class CalculationLogModel
    {
        public CalculationLogModel()
        {
        }

        public CalculationLogModel(int number):this()
        {
            Number = number;
        }

        public CalculationLogModel(CalculationLog log, int number, string method, int threadId) :this(number)
        {
            var i = 0;
            ControllerStartThreadId = Thread.CurrentThread.ManagedThreadId;
            ControllerEndThreadId = Thread.CurrentThread.ManagedThreadId;
            EndThreadId = log.EndThreadId;
            StartThreadId = log.StartThreadId;
            MilliSeconds = log.MilliSeconds;
            Items = new List<CalculationLogItemModel>();
            log.Items.ForEach(x => Items.Add(new CalculationLogItemModel
            {
                Number = ++i,
                MilliSeconds = x.MilliSeconds,
                Result = x.Result,
                ThreadId = x.ThreadId,
                Name = x.Name
            }));
            Method = method;
        }

        public string Method { get; set; }
        public int Number { get; set; }
        public double MilliSeconds { get; set; }
        public List<CalculationLogItemModel> Items { get; set; }
        public int ControllerStartThreadId { get; private set; }
        public int ControllerEndThreadId { get; set; }
        public int EndThreadId { get; set; }
        public int StartThreadId { get; set; }
    }
}