using CustomControls;
using System.Windows.Forms;
using ToDo = Todo.ToDo;
using TodoItem = DbLibrary.Models.TodoItem;
using ToDoApp.Forms;
using Todo.Enums;
using Todo.TimerToDo;

namespace ToDoApp
{
    public partial class TodoForm : Form
    {
        // Создаем экземпляр класса Todo
        public ToDo todo = new(); 

        // Создаем экземпляр класса TodoStatusChecker
        private readonly TodoStatusChecker checker = new();

        public TodoForm()
        {
            // Инициализируем компоненты формы
            InitializeComponent(); 

            // 
            UpdateToDoList(); 

            /* RoundedButton button1 = new RoundedButton
            {
                Location = new Point(30, 50),
                Name = "button1",
                Size = new Size(100, 50),
                TabIndex = 1,
                Text = "Круглая кнопка",
                UseVisualStyleBackColor = true,
                BackColor = Color.LightBlue,
                BorderRadius = 25 // Радиус скругления
            };

            this.Controls.Add(button1);
            */
        }

        // 
        public void TodoForm_Load(object sender, EventArgs e)
        {
            checker.Start();
        }

        // 
        private void BtnCreateNewToDo_Click(object sender, EventArgs e)
        {
            CreateOrUpdateToDo_Form createNewToDo = new(Convert.ToBoolean(((Button)sender).TabIndex));

            createNewToDo.ShowDialog();

            // Обновляем список задач после создания новой задачи
            UpdateToDoList();
        }

        // 
        private void BtnUpdateToDo_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса UpdateToDo_Form
            UpdateToDo_Form createNewToDo = new(((Button)sender).TabIndex);

            createNewToDo.ShowDialog();
        }

        public void UpdateToDoList()
        {
            // Получаем все задачи из базы данных
            List<TodoItem> newAllTodos = todo.GetNewToDoList();

            // Получаем все задачи из базы данных
            var countsByPriority = newAllTodos
                .GroupBy(todo => (PriorityToDo)todo.Priority) // Explicitly cast 'int' to 'TaskStatusToDo'
                .ToDictionary(g => g.Key, g => g.Count());

            // Обновляем счетчики приоритетов
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
