namespace ToDoApp.Forms
{
    partial class UpdateToDo_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxUpdateTask = new GroupBox();
            BtnCloseUpdateForm = new Button();
            labelName = new Label();
            groupBoxSort = new GroupBox();
            labelPriority = new Label();
            comboBoxPrioritySort = new ComboBox();
            groupBoxSort.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUpdateTask
            // 
            groupBoxUpdateTask.Location = new Point(22, 109);
            groupBoxUpdateTask.Name = "groupBoxUpdateTask";
            groupBoxUpdateTask.Size = new Size(766, 304);
            groupBoxUpdateTask.TabIndex = 1;
            groupBoxUpdateTask.TabStop = false;
            // 
            // BtnCloseUpdateForm
            // 
            BtnCloseUpdateForm.BackColor = Color.Gray;
            BtnCloseUpdateForm.Location = new Point(643, 424);
            BtnCloseUpdateForm.Name = "BtnCloseUpdateForm";
            BtnCloseUpdateForm.Size = new Size(111, 23);
            BtnCloseUpdateForm.TabIndex = 2;
            BtnCloseUpdateForm.Text = "Close";
            BtnCloseUpdateForm.UseVisualStyleBackColor = false;
            BtnCloseUpdateForm.Click += BtnCloseUpdateForm_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelName.Location = new Point(341, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 25);
            labelName.TabIndex = 3;
            // 
            // groupBoxSort
            // 
            groupBoxSort.Controls.Add(labelPriority);
            groupBoxSort.Controls.Add(comboBoxPrioritySort);
            groupBoxSort.Location = new Point(36, 12);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(732, 66);
            groupBoxSort.TabIndex = 4;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Location = new Point(37, 19);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(90, 15);
            labelPriority.TabIndex = 1;
            labelPriority.Text = "По приоритету";
            // 
            // comboBoxPrioritySort
            // 
            comboBoxPrioritySort.FormattingEnabled = true;
            comboBoxPrioritySort.Location = new Point(22, 37);
            comboBoxPrioritySort.Name = "comboBoxPrioritySort";
            comboBoxPrioritySort.Size = new Size(121, 23);
            comboBoxPrioritySort.TabIndex = 0;
            // 
            // UpdateToDo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxSort);
            Controls.Add(labelName);
            Controls.Add(BtnCloseUpdateForm);
            Controls.Add(groupBoxUpdateTask);
            Name = "UpdateToDo_Form";
            Text = "Обновить событие";
            groupBoxSort.ResumeLayout(false);
            groupBoxSort.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUpdateTask;
        private Button BtnCloseUpdateForm;
        private Label labelName;
        private GroupBox groupBoxSort;
        private Label labelPriority;
        private ComboBox comboBoxPrioritySort;
    }
}