using AsyncExamples.Domain;
using AsyncExamples.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace AsyncExamples.Forms
{
    public partial class ExamplesForm : Form
    {
        public ExamplesForm()
        {
            InitializeComponent();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            SyncTextbox.Lines = new[] { "In progress..." };

            var threadId = Thread.CurrentThread.ManagedThreadId;
            var service = new CalculationService();
            var log = service.Calculate(Convert.ToInt32(NumberTextBox.Text));

            SyncTextbox.Lines = GetText(SyncButton.Text, log, threadId);
        }

        private async void ASyncButton_Click(object sender, EventArgs e)
        {
            AsyncTextBox.Lines = new[] { "In progress..." };

            var threadId = Thread.CurrentThread.ManagedThreadId;
            var service = new CalculationService();
            var log = await service.AsyncCalculate(Convert.ToInt32(NumberTextBox.Text));

            AsyncTextBox.Lines = GetText(AsyncButton.Text, log, threadId);
        }

        private async void AsyncWithTaskButton_Click(object sender, EventArgs e)
        {
            AsyncWithTaskTextBox.Lines = new[] { "In progress..." };

            var threadId = Thread.CurrentThread.ManagedThreadId;
            var service = new CalculationService();
            var log = await service.AsyncWithTaskCalculate(Convert.ToInt32(NumberTextBox.Text));

            AsyncWithTaskTextBox.Lines = GetText(AsyncWithTaskButton.Text, log, threadId);
        }

        private string[] GetText(string method, CalculationLog log, int threadId)
        {
            var text = new List<string>();

            text.Add($"---- {method} ----");
            text.Add($"");
            text.Add($"Form thread ID: {threadId}");
            text.Add($"DomainService thread ID: {log.StartThreadId}");
            text.Add($"");
            var i = 0;
            foreach(var item in log.Items)
            {
                text.Add($"{++i}. Thread ID: {item.ThreadId}  {item.Name} ---- Result: {item.Result} ---- Elapsed time(ms): {item.MilliSeconds}");
            }
            text.Add($"");
            text.Add($"DomainService thread ID: {log.EndThreadId}");
            text.Add($"Form thread ID: {Thread.CurrentThread.ManagedThreadId}");
            text.Add($"Elapsed time: {log.MilliSeconds}");

            return text.ToArray();
        }
    }
}
