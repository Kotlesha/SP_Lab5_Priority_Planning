using Microsoft.VisualStudio.Threading;

namespace SP_Lab5_Priority_Planning
{
    public partial class PriorityPlanning : Form
    {
        private PriorityPlanningScheduler scheduler;
        private const int minCountOfProcessess = 2;
        private const int maxCountOfProcessess = 10;
        private Control[] controls;

        public PriorityPlanning()
        {
            InitializeComponent();
            scheduler = new();
            processesInformation.DataSource = scheduler.Processes;
            controls = new Control[] { Start, RemoveProcess, AddProcess, QuantumOfTime, ExecutingTime, Priority };
        }

        private void AddProcess_Click(object sender, EventArgs e)
        {
            if (scheduler.CheckProcessesCountMax(maxCountOfProcessess))
            {
                MessageBox.Show("Максимальное количество процессов равно 10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            scheduler.AddProcesss((int)Priority.Value, ExecutingTime.Value);
        }

        private void RemoveProcess_Click(object sender, EventArgs e)
        {
            if (processesInformation.SelectedRows.Count > 0)
            {
                var index = processesInformation.SelectedRows[0].Index;

                if (!scheduler.RemoveProcess(index))
                {
                    MessageBox.Show("Данный процесс прерван. Его нельзя удалить!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            if (!scheduler.CheckProcessesCount(minCountOfProcessess, maxCountOfProcessess))
            {
                MessageBox.Show("Количество процессов должно быть в промежутке от 2 до 10", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            scheduler.QuantumOfTime = QuantumOfTime.Value;
            ChangeStateControl(false);

            if (scheduler.IsRunning)
            {
                scheduler.Continue();
                return;
            }

            await scheduler.StartAsync();
            ChangeStateControl(true);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            scheduler.Pause();
            ChangeStateControl(true);
        }

        private void processesInformation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (processesInformation.Rows.Count > 0)
            {
                processesInformation.Rows[0].Selected = true;
                processesInformation.CurrentCell = processesInformation.Rows[0].Cells[0];
            }
        }

        private void ChangeStateControl(bool state)
        {
            foreach (var control in controls) control.Enabled = state;
        }
    }
}