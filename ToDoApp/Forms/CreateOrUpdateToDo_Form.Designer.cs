namespace ToDoApp.Forms
{
    partial class CreateOrUpdateToDo_Form
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
            textBoxThema = new TextBox();
            labelNameOrThema = new Label();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            comboBoxPriority = new ComboBox();
            labelPriority = new Label();
            buttonCencelAndCloseForm = new Button();
            buttonSaveNewToDo = new Button();
            dateTimePickerEvent = new DateTimePicker();
            SuspendLayout();
            // 
            // textBoxThema
            // 
            textBoxThema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxThema.Location = new Point(177, 29);
            textBoxThema.Name = "textBoxThema";
            textBoxThema.Size = new Size(611, 29);
            textBoxThema.TabIndex = 0;
            // 
            // labelNameOrThema
            // 
            labelNameOrThema.AutoSize = true;
            labelNameOrThema.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNameOrThema.Location = new Point(11, 29);
            labelNameOrThema.Name = "labelNameOrThema";
            labelNameOrThema.Size = new Size(160, 25);
            labelNameOrThema.TabIndex = 1;
            labelNameOrThema.Text = "Название, Тема:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescription.Location = new Point(177, 68);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(611, 106);
            textBoxDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(12, 68);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(105, 25);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Описание:";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(177, 191);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(121, 29);
            comboBoxPriority.TabIndex = 4;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPriority.Location = new Point(12, 195);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(130, 25);
            labelPriority.TabIndex = 5;
            labelPriority.Text = "Приоритет:";
            // 
            // buttonCencelAndCloseForm
            // 
            buttonCencelAndCloseForm.BackColor = Color.FromArgb(255, 192, 192);
            buttonCencelAndCloseForm.Location = new Point(674, 192);
            buttonCencelAndCloseForm.Name = "buttonCencelAndCloseForm";
            buttonCencelAndCloseForm.Size = new Size(111, 29);
            buttonCencelAndCloseForm.TabIndex = 6;
            buttonCencelAndCloseForm.Text = "Отменить";
            buttonCencelAndCloseForm.UseVisualStyleBackColor = false;
            buttonCencelAndCloseForm.Click += ButtonCencelAndCloseForm_Click;
            // 
            // buttonSaveNewToDo
            // 
            buttonSaveNewToDo.BackColor = Color.FromArgb(192, 255, 192);
            buttonSaveNewToDo.ForeColor = Color.Black;
            buttonSaveNewToDo.Location = new Point(564, 191);
            buttonSaveNewToDo.Name = "buttonSaveNewToDo";
            buttonSaveNewToDo.Size = new Size(104, 30);
            buttonSaveNewToDo.TabIndex = 7;
            buttonSaveNewToDo.Text = "Сохранить";
            buttonSaveNewToDo.UseVisualStyleBackColor = false;
            buttonSaveNewToDo.Click += ButtonSaveNewToDo_Click;
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerEvent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerEvent.Format = DateTimePickerFormat.Custom;
            dateTimePickerEvent.Location = new Point(342, 192);
            dateTimePickerEvent.MaxDate = new DateTime(2035, 12, 31, 0, 0, 0, 0);
            dateTimePickerEvent.MinDate = new DateTime(2025, 4, 7, 0, 0, 0, 0);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(200, 29);
            dateTimePickerEvent.TabIndex = 10;
            // 
            // CreateOrUpdateToDo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            Controls.Add(dateTimePickerEvent);
            Controls.Add(buttonSaveNewToDo);
            Controls.Add(buttonCencelAndCloseForm);
            Controls.Add(labelPriority);
            Controls.Add(comboBoxPriority);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelNameOrThema);
            Controls.Add(textBoxThema);
            Name = "CreateOrUpdateToDo_Form";
            Text = "Создать или обновить событие";
            Load += CreateNewToDo_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxThema;
        private Label labelNameOrThema;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private ComboBox comboBoxPriority;
        private Label labelPriority;
        private Button buttonCencelAndCloseForm;
        private Button buttonSaveNewToDo;
        private DateTimePicker dateTimePickerEvent;
    }
}