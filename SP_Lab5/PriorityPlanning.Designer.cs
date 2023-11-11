namespace SP_Lab5_Priority_Planning
{
    partial class PriorityPlanning
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorityPlanning));
            panel1 = new Panel();
            processesInformation = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            Stop = new Button();
            Start = new Button();
            label7 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            QuantumOfTime = new NumericUpDown();
            label6 = new Label();
            panel3 = new Panel();
            RemoveProcess = new Button();
            AddProcess = new Button();
            label3 = new Label();
            Priority = new NumericUpDown();
            label5 = new Label();
            ExecutingTime = new NumericUpDown();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processesInformation).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantumOfTime).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Priority).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExecutingTime).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(processesInformation);
            panel1.Location = new Point(298, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 477);
            panel1.TabIndex = 0;
            // 
            // processesInformation
            // 
            processesInformation.AllowUserToAddRows = false;
            processesInformation.AllowUserToDeleteRows = false;
            processesInformation.AllowUserToResizeColumns = false;
            processesInformation.AllowUserToResizeRows = false;
            processesInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            processesInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            processesInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            processesInformation.DefaultCellStyle = dataGridViewCellStyle2;
            processesInformation.Location = new Point(13, 19);
            processesInformation.MultiSelect = false;
            processesInformation.Name = "processesInformation";
            processesInformation.ReadOnly = true;
            processesInformation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            processesInformation.RowTemplate.Height = 28;
            processesInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            processesInformation.Size = new Size(740, 440);
            processesInformation.TabIndex = 0;
            processesInformation.DataBindingComplete += processesInformation_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 6);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 1;
            label1.Text = "Информация о процессах";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 477);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 332);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 13;
            label4.Text = "Действия с процессами";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(Stop);
            panel5.Controls.Add(Start);
            panel5.Location = new Point(14, 343);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 114);
            panel5.TabIndex = 12;
            // 
            // Stop
            // 
            Stop.Location = new Point(17, 66);
            Stop.Name = "Stop";
            Stop.Size = new Size(199, 28);
            Stop.TabIndex = 1;
            Stop.Text = "Остановить все процессы";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Start
            // 
            Start.Location = new Point(16, 20);
            Start.Name = "Start";
            Start.Size = new Size(200, 28);
            Start.TabIndex = 0;
            Start.Text = "Запустить все процессы";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 229);
            label7.Name = "label7";
            label7.Size = new Size(176, 20);
            label7.TabIndex = 11;
            label7.Text = "Размер кванта времени";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(QuantumOfTime);
            panel4.Location = new Point(14, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 80);
            panel4.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 13);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 3;
            label8.Text = "Квант времени(c)";
            // 
            // QuantumOfTime
            // 
            QuantumOfTime.DecimalPlaces = 2;
            QuantumOfTime.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            QuantumOfTime.Location = new Point(14, 33);
            QuantumOfTime.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            QuantumOfTime.Name = "QuantumOfTime";
            QuantumOfTime.Size = new Size(202, 26);
            QuantumOfTime.TabIndex = 2;
            QuantumOfTime.TextAlign = HorizontalAlignment.Center;
            QuantumOfTime.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 14);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "Процесс";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(RemoveProcess);
            panel3.Controls.Add(AddProcess);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Priority);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(ExecutingTime);
            panel3.Location = new Point(14, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 188);
            panel3.TabIndex = 8;
            // 
            // RemoveProcess
            // 
            RemoveProcess.Location = new Point(126, 142);
            RemoveProcess.Name = "RemoveProcess";
            RemoveProcess.Size = new Size(90, 28);
            RemoveProcess.TabIndex = 9;
            RemoveProcess.Text = "Удалить";
            RemoveProcess.UseVisualStyleBackColor = true;
            RemoveProcess.Click += RemoveProcess_Click;
            // 
            // AddProcess
            // 
            AddProcess.Location = new Point(14, 142);
            AddProcess.Name = "AddProcess";
            AddProcess.Size = new Size(90, 28);
            AddProcess.TabIndex = 8;
            AddProcess.Text = "Добавить";
            AddProcess.UseVisualStyleBackColor = true;
            AddProcess.Click += AddProcess_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 77);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Приоритет";
            // 
            // Priority
            // 
            Priority.Location = new Point(14, 100);
            Priority.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Priority.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            Priority.Name = "Priority";
            Priority.Size = new Size(202, 26);
            Priority.TabIndex = 6;
            Priority.TextAlign = HorizontalAlignment.Center;
            Priority.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 11);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 5;
            label5.Text = "Время выполнения(c)";
            // 
            // ExecutingTime
            // 
            ExecutingTime.DecimalPlaces = 2;
            ExecutingTime.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            ExecutingTime.Location = new Point(14, 34);
            ExecutingTime.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
            ExecutingTime.Name = "ExecutingTime";
            ExecutingTime.Size = new Size(202, 26);
            ExecutingTime.TabIndex = 4;
            ExecutingTime.TextAlign = HorizontalAlignment.Center;
            ExecutingTime.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 6);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 0;
            label2.Text = "Входные данные";
            // 
            // PlanningAlgorithms
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 506);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PlanningAlgorithms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приоритетное планирование";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)processesInformation).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantumOfTime).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Priority).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExecutingTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView processesInformation;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Panel panel5;
        private Button Stop;
        private Button Start;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private NumericUpDown QuantumOfTime;
        private Label label6;
        private Panel panel3;
        private Button RemoveProcess;
        private Button AddProcess;
        private Label label3;
        private NumericUpDown Priority;
        private Label label5;
        private NumericUpDown ExecutingTime;
        private Label label2;
    }
}