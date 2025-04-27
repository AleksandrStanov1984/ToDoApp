using Todo.Enums;
using Todo.TimerToDo;
using ToDoApp.Forms;
using ToDoApp.Helpers;
using ToDo = Todo.ToDo;
using TodoItem = DbLibrary.Models.TodoItem;

namespace ToDoApp
{
    public partial class TodoForm : Form
    {
        /// <summary>
        /// Создаем экземпляр класса Todo
        /// <summary>
        public ToDo _todo = new();

        /// <summary>
        /// Создаем экземпляр класса TodoStatusChecker
        /// <summary> 
        private readonly TodoStatusChecker checker = new();

        /// <summary>
        /// Constructor for TodoForm
        /// <summary>
        public TodoForm()
        {
            // Инициализируем компоненты формы
            InitializeComponent(); 

            UpdateToDoList(); 
        }

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TodoForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем якоря для элементов управления
            FormHelper.SetAnchors(this);

            checker.Start();
        }

        private void BtnCreateNewToDo_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы для создания новой задачи
            CreateOrUpdateToDo_Form createNewToDo = new();

            // Отображаем форму для создания новой задачи
            createNewToDo.ShowDialog();

            // Обновляем список задач после создания новой задачи
            ClearAndUpdateForm();
        }

        private void BtnUpdateToDo_Click(object sender, EventArgs e)
        {
            // Получаем индекс задачи, которую нужно обновить из тега кнопки и создаем экземпляр формы для обновления задачи
            UpdateToDo_Form updateToDo = new(
                _todo, 
                Convert.ToInt32(((Button)sender).Tag)
            );

            // Отображаем форму для обновления задачи
            updateToDo.ShowDialog();

            // Обновляем список задач после создания новой задачи
            ClearAndUpdateForm();
        }

        public void RefreshTasks()
        {
            // Получаем обновлённый список задач
            List<TodoItem>[] grouped = _todo.GetToDoList();

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
            // Получаем задачи, сгруппированные по статусам: [0] — Сегодня, [1] — В планах, [2] — Все, [3] — Завершено
            List<TodoItem>[] grouped = _todo.GetToDoList();

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
                // Получаем задачи для текущей группы
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
