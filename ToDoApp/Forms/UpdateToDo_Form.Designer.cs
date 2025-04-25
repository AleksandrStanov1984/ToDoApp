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
            vScrollBar1 = new VScrollBar();
            BtnCloseUpdateForm = new Button();
            labelName = new Label();
            groupBoxUpdateTask.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUpdateTask
            // 
            groupBoxUpdateTask.Controls.Add(vScrollBar1);
            groupBoxUpdateTask.Location = new Point(22, 41);
            groupBoxUpdateTask.Name = "groupBoxUpdateTask";
            groupBoxUpdateTask.Size = new Size(753, 372);
            groupBoxUpdateTask.TabIndex = 1;
            groupBoxUpdateTask.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(733, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 389);
            vScrollBar1.TabIndex = 0;
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
            // UpdateToDo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelName);
            Controls.Add(BtnCloseUpdateForm);
            Controls.Add(groupBoxUpdateTask);
            Name = "UpdateToDo_Form";
            Text = "Обновить событие";
            groupBoxUpdateTask.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUpdateTask;
        private VScrollBar vScrollBar1;
        private Button BtnCloseUpdateForm;
        private Label labelName;
    }
}