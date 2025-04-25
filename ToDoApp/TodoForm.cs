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
            //checker.Start();
        }

        // 
        private void BtnCreateNewToDo_Click(object sender, EventArgs e)
        {
            CreateOrUpdateToDo_Form createNewToDo = new(Convert.ToBoolean(((Button)sender).TabIndex));

            createNewToDo.ShowDialog();

            // Обновляем список задач после создания новой задачи
            ClearAndUpdateForm();
        }

        // 
        private void BtnUpdateToDo_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса UpdateToDo_Form
            UpdateToDo_Form updateToDo = new(Convert.ToInt32(((Button)sender).Tag));
            updateToDo.ShowDialog();

            // Обновляем список задач после создания новой задачи
            ClearAndUpdateForm();
        }

        //public void UpdateToDoList()
        //{
        //    // Получаем задачи, сгруппированные по статусам:
        //    // [0] — Сегодня, [1] — В планах, [2] — Все, [3] — Завершено
        //    List<TodoItem>[] grouped = todo.GetToDoList();

        //    // Обработка каждой статусной группы по очереди
        //    for (int i = 0; i < grouped.Length; i++)
        //    {
        //        var todos = grouped[i];

        //        var countsByPriority = todos
        //            .GroupBy(todo => (PriorityToDo)todo.Priority)
        //            .ToDictionary(g => g.Key, g => g.Count());

        //        // Обновляем соответствующие лейблы в зависимости от группы
        //        foreach ((PriorityToDo priority, int count) in countsByPriority)
        //        {

        //            switch (i)
        //            {
        //                case 0: // Сегодня
        //                    switch (priority)
        //                    {
        //                        case PriorityToDo.Low: labelLowCounterPriorityToday.Text = count.ToString(); break;
        //                        case PriorityToDo.Medium: labelMediumCounterPriorityToday.Text = count.ToString(); break;
        //                        case PriorityToDo.High: labelHighCounterPriorityToday.Text = count.ToString(); break;
        //                        case PriorityToDo.Critical: labelCriticalCounterPriorityToday.Text = count.ToString(); break;
        //                    }
        //                    break;

        //                case 1: // В планах
        //                    switch (priority)
        //                    {
        //                        case PriorityToDo.Low: labelLowCounterPriorityInPlans.Text = count.ToString(); break;
        //                        case PriorityToDo.Medium: labelMediumCounterPriorityInPlans.Text = count.ToString(); break;
        //                        case PriorityToDo.High: labelHighCounterPriorityInPlans.Text = count.ToString(); break;
        //                        case PriorityToDo.Critical: labelCriticalCounterPriorityInPlans.Text = count.ToString(); break;
        //                    }
        //                    break;

        //                case 2: // Все
        //                    switch (priority)
        //                    {
        //                        case PriorityToDo.Low: labelLowCounterPriorityAll.Text = count.ToString(); break;
        //                        case PriorityToDo.Medium: labelMediumCounterPriorityAll.Text = count.ToString(); break;
        //                        case PriorityToDo.High: labelHighCounterPriorityAll.Text = count.ToString(); break;
        //                        case PriorityToDo.Critical: labelCriticalCounterPriorityAll.Text = count.ToString(); break;
        //                    }
        //                    break;

        //                case 3: // Завершено
        //                    switch (priority)
        //                    {
        //                        case PriorityToDo.Low: labelLowCounterPriorityClosed.Text = count.ToString(); break;
        //                        case PriorityToDo.Medium: labelMediumCounterPriorityClosed.Text = count.ToString(); break;
        //                        case PriorityToDo.High: labelHighCounterPriorityClosed.Text = count.ToString(); break;
        //                        case PriorityToDo.Critical: labelCriticalCounterPriorityClosed.Text = count.ToString(); break;
        //                    }
        //                    break;
        //            }
        //        }
        //    }
        //}

        public void RefreshTasks()
        {
            // Получаем обновлённый список задач
            List<TodoItem>[] grouped = todo.GetToDoList();

            // Перерисовываем задачи в groupBox
            UpdateToDoList();
        }

        public void ClearAndUpdateForm()
        {
            // Очищаем значения счетчиков для всех приоритетов и статусов
            labelLowCounterPriorityToday.Text = "0";
            labelMediumCounterPriorityToday.Text = "0";
            labelHighCounterPriorityToday.Text = "0";
            labelCriticalCounterPriorityToday.Text = "0";

            labelLowCounterPriorityInPlans.Text = "0";
            labelMediumCounterPriorityInPlans.Text = "0";
            labelHighCounterPriorityInPlans.Text = "0";
            labelCriticalCounterPriorityInPlans.Text = "0";

            labelLowCounterPriorityAll.Text = "0";
            labelMediumCounterPriorityAll.Text = "0";
            labelHighCounterPriorityAll.Text = "0";
            labelCriticalCounterPriorityAll.Text = "0";

            labelLowCounterPriorityClosed.Text = "0";
            labelMediumCounterPriorityClosed.Text = "0";
            labelHighCounterPriorityClosed.Text = "0";
            labelCriticalCounterPriorityClosed.Text = "0";

            // Обновить форму, если нужно перерисовать элементы
            this.RefreshTasks(); // Обновляет форму
        }



        public void UpdateToDoList()
        {
            // Получаем задачи, сгруппированные по статусам:
            // [0] — Сегодня, [1] — В планах, [2] — Все, [3] — Завершено
            List<TodoItem>[] grouped = todo.GetToDoList();

            // Словарь для отображения лейблов в зависимости от статуса и приоритета
            var labelDictionary = new Dictionary<int, Dictionary<PriorityToDo, Label>>()
    {
        { 0, new Dictionary<PriorityToDo, Label> // Сегодня
            {
                { PriorityToDo.Low, labelLowCounterPriorityToday },
                { PriorityToDo.Medium, labelMediumCounterPriorityToday },
                { PriorityToDo.High, labelHighCounterPriorityToday },
                { PriorityToDo.Critical, labelCriticalCounterPriorityToday }
            }
        },
        { 1, new Dictionary<PriorityToDo, Label> // В планах
            {
                { PriorityToDo.Low, labelLowCounterPriorityInPlans },
                { PriorityToDo.Medium, labelMediumCounterPriorityInPlans },
                { PriorityToDo.High, labelHighCounterPriorityInPlans },
                { PriorityToDo.Critical, labelCriticalCounterPriorityInPlans }
            }
        },
        { 2, new Dictionary<PriorityToDo, Label> // Все
            {
                { PriorityToDo.Low, labelLowCounterPriorityAll },
                { PriorityToDo.Medium, labelMediumCounterPriorityAll },
                { PriorityToDo.High, labelHighCounterPriorityAll },
                { PriorityToDo.Critical, labelCriticalCounterPriorityAll }
            }
        },
        { 3, new Dictionary<PriorityToDo, Label> // Завершено
            {
                { PriorityToDo.Low, labelLowCounterPriorityClosed },
                { PriorityToDo.Medium, labelMediumCounterPriorityClosed },
                { PriorityToDo.High, labelHighCounterPriorityClosed },
                { PriorityToDo.Critical, labelCriticalCounterPriorityClosed }
            }
        }
    };

            // Обработка каждой статусной группы по очереди
            for (int i = 0; i < grouped.Length; i++)
            {
                var todos = grouped[i];

                // Группировка задач по приоритетам
                var countsByPriority = todos
                    .GroupBy(todo => (PriorityToDo)todo.Priority)
                    .ToDictionary(g => g.Key, g => g.Count());

                // Обновляем соответствующие лейблы в зависимости от группы
                foreach ((PriorityToDo priority, int count) in countsByPriority)
                {
                    // Проверяем, существует ли соответствующий лейбл для этого статуса и приоритета
                    if (labelDictionary.ContainsKey(i) && labelDictionary[i].ContainsKey(priority))
                    {
                        labelDictionary[i][priority].Text = count.ToString();
                    }
                }
            }
        }

    }
}
