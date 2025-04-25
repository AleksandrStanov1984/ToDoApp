using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Todo.Enums;
using TDTaskStatus = Todo.Enums.PriorityToDo;
using ToDo = Todo.ToDo;

namespace ToDoApp.Forms;

public partial class CreateOrUpdateToDo_Form : Form
{
    public ToDo todo = new(); // Создаем экземпляр класса Todo с ID 0  

    public CreateOrUpdateToDo_Form(bool _newOrOldTask)
    {
        InitializeComponent();

        todo.NewTask = _newOrOldTask;

        comboBoxPriority.DataSource = Enum.GetValues(typeof(TDTaskStatus));
    }

    private void CreateNewToDo_Form_Load(object sender, EventArgs e)
    {
        dateTimePickerEvent.MinDate = DateTime.Now;
    }

    private void ButtonSaveNewToDo_Click(object sender, EventArgs e)
    {
        if (comboBoxPriority.SelectedItem is TDTaskStatus selected)
        {
            try
            {
                todo.CreateAddToDoEvent
                    (
                    textBoxThema.Text,
                    textBoxDescription.Text, 
                    (PriorityToDo)comboBoxPriority.SelectedItem,
                    dateTimePickerEvent.Value
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        else
        {
            MessageBox.Show("Ошибка: Не выбран приоритет задачи.");
        }

        Close();
    }

    private void ButtonCencelAndCloseForm_Click(object sender, EventArgs e)
    {
        Close(); // Закрывает текущую форму  
    }
}
