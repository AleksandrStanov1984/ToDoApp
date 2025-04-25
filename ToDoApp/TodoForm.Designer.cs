namespace ToDoApp
{
    partial class TodoForm
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
            NameApp = new Label();
            groupBoxToday = new GroupBox();
            BtnUpdateToday = new Button();
            groupBoxPriorityCounterToday = new GroupBox();
            labelHighCounterPriorityToday = new Label();
            labeMediumPriorityToday = new Label();
            labelLowCounterPriorityToday = new Label();
            labelMediumCounterPriorityToday = new Label();
            labelCriticalCounterPriorityToday = new Label();
            labeLowPriorityToday = new Label();
            labelCriticalPriorityToday = new Label();
            labelHighPriorityToday = new Label();
            pictureBoxToday = new PictureBox();
            LabelToday = new Label();
            groupBoxInPlans = new GroupBox();
            BtnUpdateInPlans = new Button();
            groupBoxPriorityCounterInPlans = new GroupBox();
            labelHighCounterPriorityInPlans = new Label();
            labeMediumPriorityInPlans = new Label();
            labelLowCounterPriorityInPlans = new Label();
            labelMediumCounterPriorityInPlans = new Label();
            labelCriticalCounterPriorityInPlans = new Label();
            labeLowPriorityInPlans = new Label();
            labelCriticalPriorityInPlans = new Label();
            labelHighPriorityInPlans = new Label();
            pictureBoxInPlans = new PictureBox();
            labelInPlans = new Label();
            groupBox1 = new GroupBox();
            BtnUpdateClosed = new Button();
            groupBoxPriorityCounterClosed = new GroupBox();
            labelHighCounterPriorityClosed = new Label();
            labeMediumPriorityClosed = new Label();
            labelLowCounterPriorityClosed = new Label();
            labelMediumCounterPriorityClosed = new Label();
            labelCriticalCounterPriorityClosed = new Label();
            labeLowPriorityClosed = new Label();
            labelCriticalPriorityClosed = new Label();
            labelHighPriorityClosed = new Label();
            pictureBoxClosed = new PictureBox();
            labelClosed = new Label();
            groupBox2 = new GroupBox();
            BtnUpdateAll = new Button();
            groupBoxPriorityCounterAll = new GroupBox();
            labelHighCounterPriorityAll = new Label();
            labeMediumPriorityAll = new Label();
            labelLowCounterPriorityAll = new Label();
            labelMediumCounterPriorityAll = new Label();
            labelCriticalCounterPriorityAll = new Label();
            labeLowPriorityAll = new Label();
            labelCriticalPriorityAll = new Label();
            labelHighPriorityAll = new Label();
            pictureBoxAll = new PictureBox();
            labelAll = new Label();
            BtnCreateNewToDo = new Button();
            dataGridView1 = new DataGridView();
            groupBoxToday.SuspendLayout();
            groupBoxPriorityCounterToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToday).BeginInit();
            groupBoxInPlans.SuspendLayout();
            groupBoxPriorityCounterInPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInPlans).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxPriorityCounterClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).BeginInit();
            groupBox2.SuspendLayout();
            groupBoxPriorityCounterAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NameApp
            // 
            NameApp.AutoSize = true;
            NameApp.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameApp.ForeColor = Color.FromArgb(255, 128, 128);
            NameApp.Location = new Point(24, 14);
            NameApp.Name = "NameApp";
            NameApp.Size = new Size(141, 43);
            NameApp.TabIndex = 0;
            NameApp.Text = "ToDo App";
            // 
            // groupBoxToday
            // 
            groupBoxToday.Controls.Add(BtnUpdateToday);
            groupBoxToday.Controls.Add(groupBoxPriorityCounterToday);
            groupBoxToday.Controls.Add(pictureBoxToday);
            groupBoxToday.Controls.Add(LabelToday);
            groupBoxToday.Location = new Point(24, 60);
            groupBoxToday.Name = "groupBoxToday";
            groupBoxToday.Size = new Size(383, 110);
            groupBoxToday.TabIndex = 1;
            groupBoxToday.TabStop = false;
            // 
            // BtnUpdateToday
            // 
            BtnUpdateToday.ForeColor = Color.Gray;
            BtnUpdateToday.Location = new Point(302, 10);
            BtnUpdateToday.Name = "BtnUpdateToday";
            BtnUpdateToday.Size = new Size(75, 23);
            BtnUpdateToday.TabIndex = 0;
            BtnUpdateToday.Tag = "1";
            BtnUpdateToday.Text = "Update";
            BtnUpdateToday.UseVisualStyleBackColor = true;
            BtnUpdateToday.Click += BtnUpdateToDo_Click;
            // 
            // groupBoxPriorityCounterToday
            // 
            groupBoxPriorityCounterToday.Controls.Add(labelHighCounterPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labeMediumPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labelLowCounterPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labelMediumCounterPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labelCriticalCounterPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labeLowPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labelCriticalPriorityToday);
            groupBoxPriorityCounterToday.Controls.Add(labelHighPriorityToday);
            groupBoxPriorityCounterToday.ForeColor = SystemColors.ActiveBorder;
            groupBoxPriorityCounterToday.Location = new Point(185, 36);
            groupBoxPriorityCounterToday.Name = "groupBoxPriorityCounterToday";
            groupBoxPriorityCounterToday.Size = new Size(192, 64);
            groupBoxPriorityCounterToday.TabIndex = 5;
            groupBoxPriorityCounterToday.TabStop = false;
            // 
            // labelHighCounterPriorityToday
            // 
            labelHighCounterPriorityToday.AutoSize = true;
            labelHighCounterPriorityToday.Font = new Font("Segoe UI", 16F);
            labelHighCounterPriorityToday.ForeColor = Color.Blue;
            labelHighCounterPriorityToday.Location = new Point(111, 31);
            labelHighCounterPriorityToday.Name = "labelHighCounterPriorityToday";
            labelHighCounterPriorityToday.Size = new Size(25, 30);
            labelHighCounterPriorityToday.TabIndex = 10;
            labelHighCounterPriorityToday.Text = "0";
            // 
            // labeMediumPriorityToday
            // 
            labeMediumPriorityToday.AutoSize = true;
            labeMediumPriorityToday.ForeColor = Color.Lime;
            labeMediumPriorityToday.Location = new Point(45, 19);
            labeMediumPriorityToday.Name = "labeMediumPriorityToday";
            labeMediumPriorityToday.Size = new Size(52, 15);
            labeMediumPriorityToday.TabIndex = 5;
            labeMediumPriorityToday.Text = "Medium";
            // 
            // labelLowCounterPriorityToday
            // 
            labelLowCounterPriorityToday.AutoSize = true;
            labelLowCounterPriorityToday.Font = new Font("Segoe UI", 16F);
            labelLowCounterPriorityToday.ForeColor = Color.Gray;
            labelLowCounterPriorityToday.Location = new Point(14, 31);
            labelLowCounterPriorityToday.Name = "labelLowCounterPriorityToday";
            labelLowCounterPriorityToday.Size = new Size(25, 30);
            labelLowCounterPriorityToday.TabIndex = 9;
            labelLowCounterPriorityToday.Text = "0";
            // 
            // labelMediumCounterPriorityToday
            // 
            labelMediumCounterPriorityToday.AutoSize = true;
            labelMediumCounterPriorityToday.Font = new Font("Segoe UI", 16F);
            labelMediumCounterPriorityToday.ForeColor = Color.Lime;
            labelMediumCounterPriorityToday.Location = new Point(62, 31);
            labelMediumCounterPriorityToday.Name = "labelMediumCounterPriorityToday";
            labelMediumCounterPriorityToday.Size = new Size(25, 30);
            labelMediumCounterPriorityToday.TabIndex = 3;
            labelMediumCounterPriorityToday.Text = "0";
            // 
            // labelCriticalCounterPriorityToday
            // 
            labelCriticalCounterPriorityToday.AutoSize = true;
            labelCriticalCounterPriorityToday.Font = new Font("Segoe UI", 16F);
            labelCriticalCounterPriorityToday.ForeColor = Color.Red;
            labelCriticalCounterPriorityToday.Location = new Point(161, 31);
            labelCriticalCounterPriorityToday.Name = "labelCriticalCounterPriorityToday";
            labelCriticalCounterPriorityToday.Size = new Size(25, 30);
            labelCriticalCounterPriorityToday.TabIndex = 8;
            labelCriticalCounterPriorityToday.Text = "0";
            // 
            // labeLowPriorityToday
            // 
            labeLowPriorityToday.AutoSize = true;
            labeLowPriorityToday.ForeColor = Color.Gray;
            labeLowPriorityToday.Location = new Point(10, 19);
            labeLowPriorityToday.Name = "labeLowPriorityToday";
            labeLowPriorityToday.Size = new Size(29, 15);
            labeLowPriorityToday.TabIndex = 4;
            labeLowPriorityToday.Text = "Low";
            // 
            // labelCriticalPriorityToday
            // 
            labelCriticalPriorityToday.AutoSize = true;
            labelCriticalPriorityToday.ForeColor = Color.Red;
            labelCriticalPriorityToday.Location = new Point(142, 19);
            labelCriticalPriorityToday.Name = "labelCriticalPriorityToday";
            labelCriticalPriorityToday.Size = new Size(44, 15);
            labelCriticalPriorityToday.TabIndex = 7;
            labelCriticalPriorityToday.Text = "Critical";
            // 
            // labelHighPriorityToday
            // 
            labelHighPriorityToday.AutoSize = true;
            labelHighPriorityToday.ForeColor = Color.Blue;
            labelHighPriorityToday.Location = new Point(103, 19);
            labelHighPriorityToday.Name = "labelHighPriorityToday";
            labelHighPriorityToday.Size = new Size(33, 15);
            labelHighPriorityToday.TabIndex = 6;
            labelHighPriorityToday.Text = "High";
            // 
            // pictureBoxToday
            // 
            pictureBoxToday.Location = new Point(16, 62);
            pictureBoxToday.Name = "pictureBoxToday";
            pictureBoxToday.Size = new Size(77, 42);
            pictureBoxToday.TabIndex = 2;
            pictureBoxToday.TabStop = false;
            // 
            // LabelToday
            // 
            LabelToday.AutoSize = true;
            LabelToday.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelToday.ForeColor = Color.Lime;
            LabelToday.Location = new Point(16, 10);
            LabelToday.Name = "LabelToday";
            LabelToday.Size = new Size(100, 27);
            LabelToday.TabIndex = 0;
            LabelToday.Text = "Сегодня";
            // 
            // groupBoxInPlans
            // 
            groupBoxInPlans.Controls.Add(BtnUpdateInPlans);
            groupBoxInPlans.Controls.Add(groupBoxPriorityCounterInPlans);
            groupBoxInPlans.Controls.Add(pictureBoxInPlans);
            groupBoxInPlans.Controls.Add(labelInPlans);
            groupBoxInPlans.Location = new Point(426, 60);
            groupBoxInPlans.Name = "groupBoxInPlans";
            groupBoxInPlans.Size = new Size(383, 110);
            groupBoxInPlans.TabIndex = 2;
            groupBoxInPlans.TabStop = false;
            // 
            // BtnUpdateInPlans
            // 
            BtnUpdateInPlans.ForeColor = Color.Gray;
            BtnUpdateInPlans.Location = new Point(302, 15);
            BtnUpdateInPlans.Name = "BtnUpdateInPlans";
            BtnUpdateInPlans.Size = new Size(75, 23);
            BtnUpdateInPlans.TabIndex = 0;
            BtnUpdateInPlans.Tag = "2";
            BtnUpdateInPlans.Text = "Update";
            BtnUpdateInPlans.UseVisualStyleBackColor = true;
            BtnUpdateInPlans.Click += BtnUpdateToDo_Click;
            // 
            // groupBoxPriorityCounterInPlans
            // 
            groupBoxPriorityCounterInPlans.Controls.Add(labelHighCounterPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labeMediumPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labelLowCounterPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labelMediumCounterPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labelCriticalCounterPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labeLowPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labelCriticalPriorityInPlans);
            groupBoxPriorityCounterInPlans.Controls.Add(labelHighPriorityInPlans);
            groupBoxPriorityCounterInPlans.ForeColor = SystemColors.ActiveBorder;
            groupBoxPriorityCounterInPlans.Location = new Point(185, 36);
            groupBoxPriorityCounterInPlans.Name = "groupBoxPriorityCounterInPlans";
            groupBoxPriorityCounterInPlans.Size = new Size(192, 64);
            groupBoxPriorityCounterInPlans.TabIndex = 6;
            groupBoxPriorityCounterInPlans.TabStop = false;
            // 
            // labelHighCounterPriorityInPlans
            // 
            labelHighCounterPriorityInPlans.AutoSize = true;
            labelHighCounterPriorityInPlans.Font = new Font("Segoe UI", 16F);
            labelHighCounterPriorityInPlans.ForeColor = Color.Blue;
            labelHighCounterPriorityInPlans.Location = new Point(111, 31);
            labelHighCounterPriorityInPlans.Name = "labelHighCounterPriorityInPlans";
            labelHighCounterPriorityInPlans.Size = new Size(25, 30);
            labelHighCounterPriorityInPlans.TabIndex = 10;
            labelHighCounterPriorityInPlans.Text = "0";
            // 
            // labeMediumPriorityInPlans
            // 
            labeMediumPriorityInPlans.AutoSize = true;
            labeMediumPriorityInPlans.ForeColor = Color.Lime;
            labeMediumPriorityInPlans.Location = new Point(45, 19);
            labeMediumPriorityInPlans.Name = "labeMediumPriorityInPlans";
            labeMediumPriorityInPlans.Size = new Size(52, 15);
            labeMediumPriorityInPlans.TabIndex = 5;
            labeMediumPriorityInPlans.Text = "Medium";
            // 
            // labelLowCounterPriorityInPlans
            // 
            labelLowCounterPriorityInPlans.AutoSize = true;
            labelLowCounterPriorityInPlans.Font = new Font("Segoe UI", 16F);
            labelLowCounterPriorityInPlans.ForeColor = Color.Gray;
            labelLowCounterPriorityInPlans.Location = new Point(14, 31);
            labelLowCounterPriorityInPlans.Name = "labelLowCounterPriorityInPlans";
            labelLowCounterPriorityInPlans.Size = new Size(25, 30);
            labelLowCounterPriorityInPlans.TabIndex = 9;
            labelLowCounterPriorityInPlans.Text = "0";
            // 
            // labelMediumCounterPriorityInPlans
            // 
            labelMediumCounterPriorityInPlans.AutoSize = true;
            labelMediumCounterPriorityInPlans.Font = new Font("Segoe UI", 16F);
            labelMediumCounterPriorityInPlans.ForeColor = Color.Lime;
            labelMediumCounterPriorityInPlans.Location = new Point(62, 31);
            labelMediumCounterPriorityInPlans.Name = "labelMediumCounterPriorityInPlans";
            labelMediumCounterPriorityInPlans.Size = new Size(25, 30);
            labelMediumCounterPriorityInPlans.TabIndex = 3;
            labelMediumCounterPriorityInPlans.Text = "0";
            // 
            // labelCriticalCounterPriorityInPlans
            // 
            labelCriticalCounterPriorityInPlans.AutoSize = true;
            labelCriticalCounterPriorityInPlans.Font = new Font("Segoe UI", 16F);
            labelCriticalCounterPriorityInPlans.ForeColor = Color.Red;
            labelCriticalCounterPriorityInPlans.Location = new Point(161, 31);
            labelCriticalCounterPriorityInPlans.Name = "labelCriticalCounterPriorityInPlans";
            labelCriticalCounterPriorityInPlans.Size = new Size(25, 30);
            labelCriticalCounterPriorityInPlans.TabIndex = 8;
            labelCriticalCounterPriorityInPlans.Text = "0";
            // 
            // labeLowPriorityInPlans
            // 
            labeLowPriorityInPlans.AutoSize = true;
            labeLowPriorityInPlans.ForeColor = Color.Gray;
            labeLowPriorityInPlans.Location = new Point(10, 19);
            labeLowPriorityInPlans.Name = "labeLowPriorityInPlans";
            labeLowPriorityInPlans.Size = new Size(29, 15);
            labeLowPriorityInPlans.TabIndex = 4;
            labeLowPriorityInPlans.Text = "Low";
            // 
            // labelCriticalPriorityInPlans
            // 
            labelCriticalPriorityInPlans.AutoSize = true;
            labelCriticalPriorityInPlans.ForeColor = Color.Red;
            labelCriticalPriorityInPlans.Location = new Point(142, 19);
            labelCriticalPriorityInPlans.Name = "labelCriticalPriorityInPlans";
            labelCriticalPriorityInPlans.Size = new Size(44, 15);
            labelCriticalPriorityInPlans.TabIndex = 7;
            labelCriticalPriorityInPlans.Text = "Critical";
            // 
            // labelHighPriorityInPlans
            // 
            labelHighPriorityInPlans.AutoSize = true;
            labelHighPriorityInPlans.ForeColor = Color.Blue;
            labelHighPriorityInPlans.Location = new Point(103, 19);
            labelHighPriorityInPlans.Name = "labelHighPriorityInPlans";
            labelHighPriorityInPlans.Size = new Size(33, 15);
            labelHighPriorityInPlans.TabIndex = 6;
            labelHighPriorityInPlans.Text = "High";
            // 
            // pictureBoxInPlans
            // 
            pictureBoxInPlans.Location = new Point(16, 52);
            pictureBoxInPlans.Name = "pictureBoxInPlans";
            pictureBoxInPlans.Size = new Size(77, 42);
            pictureBoxInPlans.TabIndex = 2;
            pictureBoxInPlans.TabStop = false;
            // 
            // labelInPlans
            // 
            labelInPlans.AutoSize = true;
            labelInPlans.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInPlans.ForeColor = Color.Red;
            labelInPlans.Location = new Point(6, 10);
            labelInPlans.Name = "labelInPlans";
            labelInPlans.Size = new Size(107, 27);
            labelInPlans.TabIndex = 0;
            labelInPlans.Text = "В планах";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnUpdateClosed);
            groupBox1.Controls.Add(groupBoxPriorityCounterClosed);
            groupBox1.Controls.Add(pictureBoxClosed);
            groupBox1.Controls.Add(labelClosed);
            groupBox1.Location = new Point(426, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 117);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // BtnUpdateClosed
            // 
            BtnUpdateClosed.ForeColor = Color.Gray;
            BtnUpdateClosed.Location = new Point(302, 13);
            BtnUpdateClosed.Name = "BtnUpdateClosed";
            BtnUpdateClosed.Size = new Size(75, 23);
            BtnUpdateClosed.TabIndex = 0;
            BtnUpdateClosed.Tag = "4";
            BtnUpdateClosed.Text = "Update";
            BtnUpdateClosed.UseVisualStyleBackColor = true;
            BtnUpdateClosed.Click += BtnUpdateToDo_Click;
            // 
            // groupBoxPriorityCounterClosed
            // 
            groupBoxPriorityCounterClosed.Controls.Add(labelHighCounterPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labeMediumPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labelLowCounterPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labelMediumCounterPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labelCriticalCounterPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labeLowPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labelCriticalPriorityClosed);
            groupBoxPriorityCounterClosed.Controls.Add(labelHighPriorityClosed);
            groupBoxPriorityCounterClosed.ForeColor = SystemColors.ActiveBorder;
            groupBoxPriorityCounterClosed.Location = new Point(185, 42);
            groupBoxPriorityCounterClosed.Name = "groupBoxPriorityCounterClosed";
            groupBoxPriorityCounterClosed.Size = new Size(192, 64);
            groupBoxPriorityCounterClosed.TabIndex = 6;
            groupBoxPriorityCounterClosed.TabStop = false;
            // 
            // labelHighCounterPriorityClosed
            // 
            labelHighCounterPriorityClosed.AutoSize = true;
            labelHighCounterPriorityClosed.Font = new Font("Segoe UI", 16F);
            labelHighCounterPriorityClosed.ForeColor = Color.Blue;
            labelHighCounterPriorityClosed.Location = new Point(111, 31);
            labelHighCounterPriorityClosed.Name = "labelHighCounterPriorityClosed";
            labelHighCounterPriorityClosed.Size = new Size(25, 30);
            labelHighCounterPriorityClosed.TabIndex = 10;
            labelHighCounterPriorityClosed.Text = "0";
            // 
            // labeMediumPriorityClosed
            // 
            labeMediumPriorityClosed.AutoSize = true;
            labeMediumPriorityClosed.ForeColor = Color.Lime;
            labeMediumPriorityClosed.Location = new Point(45, 19);
            labeMediumPriorityClosed.Name = "labeMediumPriorityClosed";
            labeMediumPriorityClosed.Size = new Size(52, 15);
            labeMediumPriorityClosed.TabIndex = 5;
            labeMediumPriorityClosed.Text = "Medium";
            // 
            // labelLowCounterPriorityClosed
            // 
            labelLowCounterPriorityClosed.AutoSize = true;
            labelLowCounterPriorityClosed.Font = new Font("Segoe UI", 16F);
            labelLowCounterPriorityClosed.ForeColor = Color.Gray;
            labelLowCounterPriorityClosed.Location = new Point(14, 31);
            labelLowCounterPriorityClosed.Name = "labelLowCounterPriorityClosed";
            labelLowCounterPriorityClosed.Size = new Size(25, 30);
            labelLowCounterPriorityClosed.TabIndex = 9;
            labelLowCounterPriorityClosed.Text = "0";
            // 
            // labelMediumCounterPriorityClosed
            // 
            labelMediumCounterPriorityClosed.AutoSize = true;
            labelMediumCounterPriorityClosed.Font = new Font("Segoe UI", 16F);
            labelMediumCounterPriorityClosed.ForeColor = Color.Lime;
            labelMediumCounterPriorityClosed.Location = new Point(62, 31);
            labelMediumCounterPriorityClosed.Name = "labelMediumCounterPriorityClosed";
            labelMediumCounterPriorityClosed.Size = new Size(25, 30);
            labelMediumCounterPriorityClosed.TabIndex = 3;
            labelMediumCounterPriorityClosed.Text = "0";
            // 
            // labelCriticalCounterPriorityClosed
            // 
            labelCriticalCounterPriorityClosed.AutoSize = true;
            labelCriticalCounterPriorityClosed.Font = new Font("Segoe UI", 16F);
            labelCriticalCounterPriorityClosed.ForeColor = Color.Red;
            labelCriticalCounterPriorityClosed.Location = new Point(161, 31);
            labelCriticalCounterPriorityClosed.Name = "labelCriticalCounterPriorityClosed";
            labelCriticalCounterPriorityClosed.Size = new Size(25, 30);
            labelCriticalCounterPriorityClosed.TabIndex = 8;
            labelCriticalCounterPriorityClosed.Text = "0";
            // 
            // labeLowPriorityClosed
            // 
            labeLowPriorityClosed.AutoSize = true;
            labeLowPriorityClosed.ForeColor = Color.Gray;
            labeLowPriorityClosed.Location = new Point(10, 19);
            labeLowPriorityClosed.Name = "labeLowPriorityClosed";
            labeLowPriorityClosed.Size = new Size(29, 15);
            labeLowPriorityClosed.TabIndex = 4;
            labeLowPriorityClosed.Text = "Low";
            // 
            // labelCriticalPriorityClosed
            // 
            labelCriticalPriorityClosed.AutoSize = true;
            labelCriticalPriorityClosed.ForeColor = Color.Red;
            labelCriticalPriorityClosed.Location = new Point(142, 19);
            labelCriticalPriorityClosed.Name = "labelCriticalPriorityClosed";
            labelCriticalPriorityClosed.Size = new Size(44, 15);
            labelCriticalPriorityClosed.TabIndex = 7;
            labelCriticalPriorityClosed.Text = "Critical";
            // 
            // labelHighPriorityClosed
            // 
            labelHighPriorityClosed.AutoSize = true;
            labelHighPriorityClosed.ForeColor = Color.Blue;
            labelHighPriorityClosed.Location = new Point(103, 19);
            labelHighPriorityClosed.Name = "labelHighPriorityClosed";
            labelHighPriorityClosed.Size = new Size(33, 15);
            labelHighPriorityClosed.TabIndex = 6;
            labelHighPriorityClosed.Text = "High";
            // 
            // pictureBoxClosed
            // 
            pictureBoxClosed.Location = new Point(16, 64);
            pictureBoxClosed.Name = "pictureBoxClosed";
            pictureBoxClosed.Size = new Size(77, 42);
            pictureBoxClosed.TabIndex = 2;
            pictureBoxClosed.TabStop = false;
            // 
            // labelClosed
            // 
            labelClosed.AutoSize = true;
            labelClosed.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClosed.ForeColor = Color.Gray;
            labelClosed.Location = new Point(6, 10);
            labelClosed.Name = "labelClosed";
            labelClosed.Size = new Size(130, 27);
            labelClosed.TabIndex = 0;
            labelClosed.Text = "Завершино";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnUpdateAll);
            groupBox2.Controls.Add(groupBoxPriorityCounterAll);
            groupBox2.Controls.Add(pictureBoxAll);
            groupBox2.Controls.Add(labelAll);
            groupBox2.Location = new Point(24, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 117);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // BtnUpdateAll
            // 
            BtnUpdateAll.ForeColor = Color.Gray;
            BtnUpdateAll.Location = new Point(302, 10);
            BtnUpdateAll.Name = "BtnUpdateAll";
            BtnUpdateAll.Size = new Size(75, 23);
            BtnUpdateAll.TabIndex = 0;
            BtnUpdateAll.Tag = "3";
            BtnUpdateAll.Text = "Update";
            BtnUpdateAll.UseVisualStyleBackColor = true;
            BtnUpdateAll.Click += BtnUpdateToDo_Click;
            // 
            // groupBoxPriorityCounterAll
            // 
            groupBoxPriorityCounterAll.Controls.Add(labelHighCounterPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labeMediumPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labelLowCounterPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labelMediumCounterPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labelCriticalCounterPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labeLowPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labelCriticalPriorityAll);
            groupBoxPriorityCounterAll.Controls.Add(labelHighPriorityAll);
            groupBoxPriorityCounterAll.ForeColor = SystemColors.ActiveBorder;
            groupBoxPriorityCounterAll.Location = new Point(185, 42);
            groupBoxPriorityCounterAll.Name = "groupBoxPriorityCounterAll";
            groupBoxPriorityCounterAll.Size = new Size(192, 64);
            groupBoxPriorityCounterAll.TabIndex = 6;
            groupBoxPriorityCounterAll.TabStop = false;
            // 
            // labelHighCounterPriorityAll
            // 
            labelHighCounterPriorityAll.AutoSize = true;
            labelHighCounterPriorityAll.Font = new Font("Segoe UI", 16F);
            labelHighCounterPriorityAll.ForeColor = Color.Blue;
            labelHighCounterPriorityAll.Location = new Point(111, 31);
            labelHighCounterPriorityAll.Name = "labelHighCounterPriorityAll";
            labelHighCounterPriorityAll.Size = new Size(25, 30);
            labelHighCounterPriorityAll.TabIndex = 10;
            labelHighCounterPriorityAll.Text = "0";
            // 
            // labeMediumPriorityAll
            // 
            labeMediumPriorityAll.AutoSize = true;
            labeMediumPriorityAll.ForeColor = Color.Lime;
            labeMediumPriorityAll.Location = new Point(45, 19);
            labeMediumPriorityAll.Name = "labeMediumPriorityAll";
            labeMediumPriorityAll.Size = new Size(52, 15);
            labeMediumPriorityAll.TabIndex = 5;
            labeMediumPriorityAll.Text = "Medium";
            // 
            // labelLowCounterPriorityAll
            // 
            labelLowCounterPriorityAll.AutoSize = true;
            labelLowCounterPriorityAll.Font = new Font("Segoe UI", 16F);
            labelLowCounterPriorityAll.ForeColor = Color.Gray;
            labelLowCounterPriorityAll.Location = new Point(14, 31);
            labelLowCounterPriorityAll.Name = "labelLowCounterPriorityAll";
            labelLowCounterPriorityAll.Size = new Size(25, 30);
            labelLowCounterPriorityAll.TabIndex = 9;
            labelLowCounterPriorityAll.Text = "0";
            // 
            // labelMediumCounterPriorityAll
            // 
            labelMediumCounterPriorityAll.AutoSize = true;
            labelMediumCounterPriorityAll.Font = new Font("Segoe UI", 16F);
            labelMediumCounterPriorityAll.ForeColor = Color.Lime;
            labelMediumCounterPriorityAll.Location = new Point(62, 31);
            labelMediumCounterPriorityAll.Name = "labelMediumCounterPriorityAll";
            labelMediumCounterPriorityAll.Size = new Size(25, 30);
            labelMediumCounterPriorityAll.TabIndex = 3;
            labelMediumCounterPriorityAll.Text = "0";
            // 
            // labelCriticalCounterPriorityAll
            // 
            labelCriticalCounterPriorityAll.AutoSize = true;
            labelCriticalCounterPriorityAll.Font = new Font("Segoe UI", 16F);
            labelCriticalCounterPriorityAll.ForeColor = Color.Red;
            labelCriticalCounterPriorityAll.Location = new Point(161, 31);
            labelCriticalCounterPriorityAll.Name = "labelCriticalCounterPriorityAll";
            labelCriticalCounterPriorityAll.Size = new Size(25, 30);
            labelCriticalCounterPriorityAll.TabIndex = 8;
            labelCriticalCounterPriorityAll.Text = "0";
            // 
            // labeLowPriorityAll
            // 
            labeLowPriorityAll.AutoSize = true;
            labeLowPriorityAll.ForeColor = Color.Gray;
            labeLowPriorityAll.Location = new Point(10, 19);
            labeLowPriorityAll.Name = "labeLowPriorityAll";
            labeLowPriorityAll.Size = new Size(29, 15);
            labeLowPriorityAll.TabIndex = 4;
            labeLowPriorityAll.Text = "Low";
            // 
            // labelCriticalPriorityAll
            // 
            labelCriticalPriorityAll.AutoSize = true;
            labelCriticalPriorityAll.ForeColor = Color.Red;
            labelCriticalPriorityAll.Location = new Point(142, 19);
            labelCriticalPriorityAll.Name = "labelCriticalPriorityAll";
            labelCriticalPriorityAll.Size = new Size(44, 15);
            labelCriticalPriorityAll.TabIndex = 7;
            labelCriticalPriorityAll.Text = "Critical";
            // 
            // labelHighPriorityAll
            // 
            labelHighPriorityAll.AutoSize = true;
            labelHighPriorityAll.ForeColor = Color.Blue;
            labelHighPriorityAll.Location = new Point(103, 19);
            labelHighPriorityAll.Name = "labelHighPriorityAll";
            labelHighPriorityAll.Size = new Size(33, 15);
            labelHighPriorityAll.TabIndex = 6;
            labelHighPriorityAll.Text = "High";
            // 
            // pictureBoxAll
            // 
            pictureBoxAll.Location = new Point(16, 64);
            pictureBoxAll.Name = "pictureBoxAll";
            pictureBoxAll.Size = new Size(77, 42);
            pictureBoxAll.TabIndex = 2;
            pictureBoxAll.TabStop = false;
            // 
            // labelAll
            // 
            labelAll.AutoSize = true;
            labelAll.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAll.ForeColor = Color.Cyan;
            labelAll.Location = new Point(16, 10);
            labelAll.Name = "labelAll";
            labelAll.Size = new Size(49, 27);
            labelAll.TabIndex = 0;
            labelAll.Text = "Все";
            // 
            // BtnCreateNewToDo
            // 
            BtnCreateNewToDo.ForeColor = Color.FromArgb(64, 64, 64);
            BtnCreateNewToDo.Location = new Point(659, 31);
            BtnCreateNewToDo.Name = "BtnCreateNewToDo";
            BtnCreateNewToDo.Size = new Size(150, 26);
            BtnCreateNewToDo.TabIndex = 1;
            BtnCreateNewToDo.Text = "Create New ToDo";
            BtnCreateNewToDo.UseVisualStyleBackColor = true;
            BtnCreateNewToDo.Click += BtnCreateNewToDo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(785, 256);
            dataGridView1.TabIndex = 6;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 587);
            Controls.Add(dataGridView1);
            Controls.Add(BtnCreateNewToDo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInPlans);
            Controls.Add(groupBoxToday);
            Controls.Add(NameApp);
            ForeColor = Color.LawnGreen;
            Name = "TodoForm";
            Text = "ToDo App";
            groupBoxToday.ResumeLayout(false);
            groupBoxToday.PerformLayout();
            groupBoxPriorityCounterToday.ResumeLayout(false);
            groupBoxPriorityCounterToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxToday).EndInit();
            groupBoxInPlans.ResumeLayout(false);
            groupBoxInPlans.PerformLayout();
            groupBoxPriorityCounterInPlans.ResumeLayout(false);
            groupBoxPriorityCounterInPlans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInPlans).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPriorityCounterClosed.ResumeLayout(false);
            groupBoxPriorityCounterClosed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClosed).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxPriorityCounterAll.ResumeLayout(false);
            groupBoxPriorityCounterAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameApp;
        private GroupBox groupBoxToday;
        private Label LabelToday;
        private Label labelMediumCounterPriorityToday;
        private PictureBox pictureBoxToday;
        private GroupBox groupBoxInPlans;
        private PictureBox pictureBoxInPlans;
        private Label labelInPlans;
        private GroupBox groupBox1;
        private PictureBox pictureBoxClosed;
        private Label labelClosed;
        private GroupBox groupBox2;
        private PictureBox pictureBoxAll;
        private Label labelAll;
        private Label labelCriticalCounterPriorityToday;
        private Label labelCriticalPriorityToday;
        private Label labelHighPriorityToday;
        private Label labeMediumPriorityToday;
        private Label labeLowPriorityToday;
        private Label labelHighCounterPriorityToday;
        private Label labelLowCounterPriorityToday;
        private GroupBox groupBoxPriorityCounterToday;
        private GroupBox groupBoxPriorityCounterInPlans;
        private Label labelHighCounterPriorityInPlans;
        private Label labeMediumPriorityInPlans;
        private Label labelLowCounterPriorityInPlans;
        private Label labelMediumCounterPriorityInPlans;
        private Label labelCriticalCounterPriorityInPlans;
        private Label labeLowPriorityInPlans;
        private Label labelCriticalPriorityInPlans;
        private Label labelHighPriorityInPlans;
        private GroupBox groupBoxPriorityCounterClosed;
        private Label labelHighCounterPriorityClosed;
        private Label labeMediumPriorityClosed;
        private Label labelLowCounterPriorityClosed;
        private Label labelMediumCounterPriorityClosed;
        private Label labelCriticalCounterPriorityClosed;
        private Label labeLowPriorityClosed;
        private Label labelCriticalPriorityClosed;
        private Label labelHighPriorityClosed;
        private GroupBox groupBoxPriorityCounterAll;
        private Label labelHighCounterPriorityAll;
        private Label labeMediumPriorityAll;
        private Label labelLowCounterPriorityAll;
        private Label labelMediumCounterPriorityAll;
        private Label labelCriticalCounterPriorityAll;
        private Label labeLowPriorityAll;
        private Label labelCriticalPriorityAll;
        private Label labelHighPriorityAll;
        private Button BtnUpdateToday;
        private Button BtnUpdateInPlans;
        private Button BtnUpdateClosed;
        private Button BtnUpdateAll;
        private Button BtnCreateNewToDo;
        private DataGridView dataGridView1;
    }
}
