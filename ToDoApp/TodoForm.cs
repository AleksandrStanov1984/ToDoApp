using CustomControls;
using System.Windows.Forms;
using ToDo = Todo.ToDo;
using TodoItem = DbLibrary.Models.TodoItem;
using ToDoApp.Forms;
using Todo.Enums;

namespace ToDoApp
{
    public partial class TodoForm : Form
    {
        public ToDo todo = new(); // Создаем экземпляр класса Todo

        public TodoForm()
        {
            InitializeComponent();

            UpdateToDoList();

            //RoundedButton button1 = new RoundedButton
            //{
            //    Location = new Point(30, 50),
            //    Name = "button1",
            //    Size = new Size(100, 50),
            //    TabIndex = 1,
            //    Text = "Круглая кнопка",
            //    UseVisualStyleBackColor = true,
            //    BackColor = Color.LightBlue,
            //    BorderRadius = 25 // Радиус скругления
            //};

            //this.Controls.Add(button1);
        }

        private void BtnCreateNewToDo_Click(object sender, EventArgs e)
        {
            CreateOrUpdateToDo_Form createNewToDo = new(Convert.ToBoolean(((Button)sender).TabIndex));
            createNewToDo.ShowDialog();

            UpdateToDoList();
        }

        private void BtnUpdateToDo_Click(object sender, EventArgs e)
        {
            UpdateToDo_Form createNewToDo = new(((Button)sender).TabIndex);
            createNewToDo.ShowDialog();
        }

        public void UpdateToDoList()
        {
            List<TodoItem> newAllTodos = todo.GetNewToDoList();

            var countsByPriority = newAllTodos
                .GroupBy(todo => (PriorityToDo)todo.Priority) // Explicitly cast 'int' to 'TaskStatusToDo'
                .ToDictionary(g => g.Key, g => g.Count());

            foreach ((PriorityToDo priority, int count) in countsByPriority)
            {
                string priorityText = priority switch
                {
                    PriorityToDo.Low => labelLowCounterPriorityAll.Text = count.ToString(),
                    PriorityToDo.Medium => labelMediumCounterPriorityAll.Text = count.ToString(),
                    PriorityToDo.High => labelHighCounterPriorityAll.Text = count.ToString(),
                    PriorityToDo.Critical => labelCriticalCounterPriorityAll.Text = count.ToString(),
                    _ => ""
                };

                Console.WriteLine(priorityText);

            }
        }
    }
}
