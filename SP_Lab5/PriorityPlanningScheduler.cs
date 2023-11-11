using Microsoft.VisualStudio.Threading;
using System.ComponentModel;

namespace SP_Lab5_Priority_Planning
{
    internal class PriorityPlanningScheduler
    {
        public BindingList<Process> Processes { get; private set; }
        public bool IsRunning { get; private set; }
        public decimal QuantumOfTime { get; set; }
        private AsyncManualResetEvent pauseEvent;

        public PriorityPlanningScheduler()
        {
            Processes = new();
            pauseEvent = new(true);
            IsRunning = false;
        }

        public void AddProcesss(int priority, decimal executingTime)
        {
            var index = Processes.Count != 0 ? Processes.Max(process => process.GetNumber()) + 1 : 1;
            var process = new Process($"Процесс {index}", priority, executingTime);
            Processes.Add(process);
        }

        public bool RemoveProcess(int index)
        {
            var process = Processes[index]; 
            if (process.Status == ProcessStatus.Interrupted) return false;
            Processes.Remove(process);
            return true;
        }

        public bool CheckProcessesCountMax(int max) => Processes.Count == max;

        public bool CheckProcessesCount(int min, int max)
        {
            if (min > max) (min, max) = (max, min);
            return Processes.Count >= min && Processes.Count <= max;
        }

        public async Task StartAsync()
        {
            IsRunning = true;

            while (true)
            {
                var item = Processes.Where(process => !process.CheckCompletedStatus() || process.CheckInterruptedStatus()).MaxBy(process => process.Priority);
                if (item is null) break;

                Processes.Remove(item);
                Processes.Insert(0, item);

                await pauseEvent.WaitAsync();
                await item.ExecuteAsync(QuantumOfTime);

                Processes.Remove(item);
                Processes.Add(item);
            }

            IsRunning = false;
        }

        public void Pause() => pauseEvent.Reset();

        public void Continue() => pauseEvent.Set();
    }
}
