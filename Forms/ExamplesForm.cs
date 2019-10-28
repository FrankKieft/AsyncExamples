using AsyncExamples.Domain;
using AsyncExamples.Domain.Utils;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AsyncExamples.Forms
{
    public partial class ExamplesForm : Form
    {
        private int _count = 0;
        private CalculationService _service;

        public ExamplesForm()
        {
            _service = new CalculationService();
            InitializeComponent();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            var n = ++_count;

            LogStart(SyncButton.Text, n);

            var log = _service.Calculate(Convert.ToInt32(NumberTextBox.Text));

            LogEnd(SyncButton.Text, log, n);
        }

        private async void ASyncButton_Click(object sender, EventArgs e)
        {
            var n = ++_count;

            LogStart(AsyncButton.Text, n);

            var log = await _service.AsyncCalculate(Convert.ToInt32(NumberTextBox.Text));

            LogEnd(AsyncButton.Text, log, n);
        }

        private async void AsyncWithTaskButton_Click(object sender, EventArgs e)
        {
            var n = ++_count;

            LogStart(AsyncWithTaskButton.Text, n);

            var log = await _service.AsyncWithTaskCalculate(Convert.ToInt32(NumberTextBox.Text));

            LogEnd(AsyncWithTaskButton.Text, log, n);
        }

        private void ParallelButton_Click(object sender, EventArgs e)
        {
            var n = ++_count;

            LogStart(ParallelButton.Text, n);

            var log = _service.ParallelCalculate(Convert.ToInt32(NumberTextBox.Text));

            LogEnd(ParallelButton.Text, log, n);
        }

        private void LogStart(string method, int n)
        {
            var text = ResultTextbox.Lines.ToList();

            text.Add($" ---- START: {method} ({n}) ----");
            text.Add($"     Form thread ID:  {Thread.CurrentThread.ManagedThreadId}");
            text.Add($"");

            ResultTextbox.Lines = text.ToArray();
        }

        private void LogEnd(string method, CalculationLog log, int n)
        {
            var text = ResultTextbox.Lines.ToList();

            text.Add($" ---- CONTINUE: {method} ({n}) ----");
            text.Add($"     Form thread ID:  {Thread.CurrentThread.ManagedThreadId}");
            text.Add($"     DomainService thread ID:  {log.StartThreadId}");
            var i = 0;
            foreach(var item in log.Items)
            {
                text.Add($"         {++i}. Thread ID:  {(item.ThreadId.ToString()+new string(' ',2)).Substring(0,2)}   {(item.Name+new string(' ',32)).Substring(0,32)}      ({NumberTextBox.Text}) {(item.Result.ToString() + new string(' ', 12)).Substring(0,12)}{item.MilliSeconds} ms");
            }
            text.Add($"     DomainService thread ID:  {log.EndThreadId}");
            text.Add($"     Elapsed time (s):  {Math.Round(log.MilliSeconds/1000,2,MidpointRounding.AwayFromZero)}");
            text.Add($"");

            ResultTextbox.Lines = text.ToArray();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextbox.Lines = new string[] { };
        }
    }
}
