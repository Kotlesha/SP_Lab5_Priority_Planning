using System.ComponentModel;

namespace SP_Lab5_Priority_Planning
{
    internal class Process : NotifyObject
    {
        [DisplayName("Название процесса")]
        public string Name { get; set; }

        [DisplayName("Приоритет")]
        public int Priority { get; set; }

        [DisplayName("Время выполнения(с)")]
        public decimal ExecutingTime { get; set; }

        private decimal remainingTime;

        [DisplayName("Оставшееся время(с)")]
        public decimal RemainingTime 
        { 
            get => remainingTime;
            set
            {
                remainingTime = value;
                OnPropertyChanged("RemainingTime");
            } 
        }

        private string status;

        [DisplayName("Статус")]
        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public Process(string name, int priority, decimal executingTime)
        {
            Name = name;
            Priority = priority;
            ExecutingTime = executingTime;
            RemainingTime = executingTime;
            Status = ProcessStatus.NotStarted;
        }

        public int GetNumber()
        {
            var data = Name.Split(' ');
            return Convert.ToInt32(data[1]);
        }

        public async Task ExecuteAsync(decimal quantumOfTime, CancellationToken token, decimal step = 0.01m)
        {
            Status = ProcessStatus.Running;
            var executeTime = RemainingTime.CompareTo(quantumOfTime) > 0 ? quantumOfTime : RemainingTime;
            
            for (decimal time = decimal.Zero; time.CompareTo(executeTime) < 0; time += step)
            {
                await Task.Delay(TimeSpan.FromSeconds((double)step), token);
                RemainingTime -= step;
            }

            Status = RemainingTime.CompareTo(decimal.Zero) > 0 ? ProcessStatus.Interrupted : ProcessStatus.Completed;
        }

        public void ResetStatus()
        {
            Status = ProcessStatus.NotStarted;
            RemainingTime = ExecutingTime;
        }

        public bool CheckCompletedStatus() => Status == ProcessStatus.Completed;

        public bool CheckInterruptedStatus() => Status == ProcessStatus.Interrupted;
    }
}
