using Todo.Enums;
using System.Data;
using DbLibrary.Models;
using ToDoApp.Properties;
using ToDo = Todo.ToDo;
using TDTaskPriority = Todo.Enums.PriorityToDo;
using ToDoApp.Helpers;

namespace ToDoApp.Forms
{
    public partial class UpdateToDo_Form : Form
    {
        /// <summary>
        /// Создаем экземпляр класса Todo
        /// <summary>
        private readonly ToDo _todo;

        private readonly int _status;

        /// <summary>
        /// Constructor for UpdateToDo_Form
        /// </summary>
        /// <param name="todoInstance"></param>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UpdateToDo_Form(ToDo todoInstance, int status)
        {
            InitializeComponent();

            // Сохраняем переданный статус
            _status = status;

            // Устанавливаем текст статуса в labelName
            InstallStatusLabel(_status);

            // Инициализируем класс ToDo
            _todo = todoInstance ?? throw new ArgumentNullException(nameof(todoInstance));

            // Проверяем статус задачи
            if (_status < 1 || _status > 4)
            {
                MessageBox.Show("Ошибка: Неверный статус задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Заполняем ComboBox значениями приоритетов
            comboBoxPrioritySort.DataSource = Enum.GetValues(typeof(TDTaskPriority));
            comboBoxPrioritySort.SelectedItem = TDTaskPriority.Critical;

            // Подключаем обработчик события
            comboBoxPrioritySort.SelectedIndexChanged += ComboBoxPrioritySort_SelectedIndexChanged;

            // Отображаем задачи в groupBox
            DisplayGroupedTodosInGroupBox();
        }

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateToDo_Form_Load(object sender, EventArgs e)
        {
            // Устанавливаем якоря для элементов управления
            FormHelper.SetAnchors(this);
        }

        /// <summary>
        /// Взять название статусов
        /// </summary>
        /// <returns></returns>
        private static string[] GetStatusHeaders()
        {
            // Возвращаем массив заголовков статусов
            return
            [
                Resource.StatusToday,
                Resource.StatusPlanned,
                Resource.StatusAll,
                Resource.StatusCompleted
            ];
        }

        /// <summary>
        /// Метод для отображения задач в groupBox
        /// </summary>
        /// <param name="sortedTodos"></param>
        private void DisplayGroupedTodosInGroupBox(List<TodoItem>[] sortedTodos)
        {
            // Очищаем groupBox перед добавлением новых задач
            groupBoxUpdateTask.Controls.Clear();

            // Создаем панель прокрутки
            var scrollPanel = CreateScrollPanel();
            int yOffset = 10;

            // Получаем заголовки статусов
            string[] statusHeaders = GetStatusHeaders();

            // Устанавливаем начальные параметры для отображения задач
            for (int i = 0; i < sortedTodos.Length; i++)
            {
                // Skip empty lists
                if (!sortedTodos[i].Any()) continue;

                // Add status header
                var headerLabel = CreateStatusHeaderLabel(statusHeaders[i], yOffset);

                // Set header label properties
                scrollPanel.Controls.Add(headerLabel);

                // Update yOffset for next task box
                yOffset += headerLabel.Height + 10;

                // Add task boxes
                foreach (var todo in sortedTodos[i])
                {
                    // Create task box
                    var taskBox = CreateTaskGroupBox(todo, yOffset);

                    // Add task box to scroll panel
                    scrollPanel.Controls.Add(taskBox);

                    // Update yOffset for next task box
                    yOffset += taskBox.Height + 10;
                }
            }

            // Устанавливаем высоту панели прокрутки
            groupBoxUpdateTask.Controls.Add(scrollPanel);
        }

        /// <summary>
        /// Метод для создания метки заголовка статуса
        /// </summary>
        /// <param name="headerText"></param>
        /// <param name="yOffset"></param>
        /// <returns></returns>
        private static Label CreateStatusHeaderLabel(string headerText, int yOffset)
        {
            // Создаем метку для заголовка статуса
            var headerLabel = new Label
            {
                Text = headerText,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, yOffset),
                AutoSize = true
            };

            return headerLabel;
        }

        /// <summary>
        /// Словарь для хранения цветов рамки и фона в зависимости от приоритета
        /// </summary>
        private readonly Dictionary<int, (Color borderColor, Color backgroundColor)> _priorityColors = new()
        {
            { (int)PriorityToDo.Low, (Color.Black, Color.DarkGray) },
            { (int)PriorityToDo.Medium, (Color.Green, Color.LightGreen) },
            { (int)PriorityToDo.High, (Color.Blue, Color.LightBlue) },
            { (int)PriorityToDo.Critical, (Color.Red, Color.LightCoral) }
        };

        // Метод для получения цветов рамки и фона в зависимости от приоритета
        private (Color borderColor, Color backgroundColor) GetPriorityColors(int priority)
        {
            // Проверяем, что приоритет корректный
            return _priorityColors.TryGetValue(priority, out (Color borderColor, Color backgroundColor) value) ? value : (Color.Black, Color.DarkGray);
        }

        // Метод для обновления списка задач
        private void RefreshTodoList()
        {
            // Получаем выбранный приоритет из ComboBox
            TDTaskPriority selectedPriority = (TDTaskPriority)comboBoxPrioritySort.SelectedItem;

            // Получаем все задачи, сгруппированные по статусам
            List<TodoItem>[] grouped = _todo.GetToDoList();

            // Сортируем задачи по выбранному приоритету
            List<TodoItem>[] sorted = SortTodosByPriority(grouped, selectedPriority);

            // Отображаем отсортированные задачи
            DisplayGroupedTodosInGroupBox(sorted);
        }

        private List<TodoItem>[] SortTodosByPriority(List<TodoItem>[] groupedTodos, TDTaskPriority selectedPriority)
        {
            // Берем только задачи текущего статуса
            var filteredTodos = groupedTodos[_status - 1]
                .Where(todo => todo.Priority == (int)selectedPriority)
                .ToList();

            // Возвращаем только текущую категорию, остальные будут пустыми
            var result = new List<TodoItem>[4];

            // Заполняем массив пустыми списками
            for (int i = 0; i < result.Length; i++)
                result[i] = new List<TodoItem>();

            // Заполняем только текущую категорию
            result[_status - 1] = filteredTodos;

            // Возвращаем отсортированные задачи
            return result;
        }

        // Обработчик для ComboBox, сортировка по приоритету
        private void ComboBoxPrioritySort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный приоритет из ComboBox
            TDTaskPriority selectedPriority = (TDTaskPriority)comboBoxPrioritySort.SelectedItem;

            // Получаем все задачи, сгруппированные по статусам
            List<TodoItem>[] groupedTodos = _todo.GetToDoList();

            // Сортируем задачи по выбранному приоритету
            var sortedTodos = SortTodosByPriority(groupedTodos, selectedPriority);

            // Отображаем отсортированные задачи
            DisplayGroupedTodosInGroupBox(sortedTodos);
        }

        // Метод для отображения задач в groupBox
        private void DisplayGroupedTodosInGroupBox()
        {
            // Очищаем groupBox перед добавлением новых задач
            groupBoxUpdateTask.Controls.Clear();

            // Получаем все задачи, сгруппированные по статусам
            List<TodoItem>[] groupedTodos = _todo.GetToDoList();

            // Проверяем, что статус задачи корректный
            if (_status < 1 || _status > groupedTodos.Length)
                return;

            // Создаем панель прокрутки
            var scrollPanel = CreateScrollPanel();

            // Устанавливаем текст статуса в labelName
            var todos = groupedTodos[_status - 1]
                .OrderByDescending(todo => todo.Priority == (int)PriorityToDo.Critical)
                .ThenBy(todo => todo.Priority)
                .ToList();

            // Устанавливаем начальные параметры для отображения задач
            int yOffset = 10;
            int groupBoxHeight = 90;
            int spacing = 10;

            // Получаем заголовки статусов
            string[] statusHeaders = GetStatusHeaders();

            // Создаем заголовок для статуса
            foreach (var todo in todos)
            {
                // Создаем метку для заголовка статуса
                GroupBox taskBox = CreateTaskGroupBox(todo, yOffset);

                // Устанавливаем цвет рамки и фона в зависимости от приоритета
                scrollPanel.Controls.Add(taskBox);

                yOffset += groupBoxHeight + spacing;
            }

            // Устанавливаем высоту панели прокрутки
            groupBoxUpdateTask.Controls.Add(CreateScrollPanel());
        }

        // Метод для создания TaskBox для каждой задачи
        private GroupBox CreateTaskGroupBox(TodoItem todo, int yOffset)
        {
            // Устанавливаем цвет рамки и фона в зависимости от приоритета
            var (borderColor, backgroundColor) = GetPriorityColors(todo.Priority);

            // Создаем TaskBox для каждой задачи
            var taskBox = new GroupBox
            {
                Text = todo.Title,
                Width = groupBoxUpdateTask.Width - 40,
                Height = 100,
                Location = new Point(10, yOffset),
                Tag = todo.Id,
                ForeColor = borderColor,
                BackColor = backgroundColor,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right 
            };

            // Устанавливаем цвет рамки
            taskBox.Controls.Add(CreateDescriptionLabel(todo.Description));
            taskBox.Controls.Add(CreateUpdateButton(todo.Id));
            taskBox.Controls.Add(CreateCloseButton(todo.Id));
            taskBox.Controls.Add(CreateDateLabel(todo.DateTimeEvent));

            // Устанавливаем цвет рамки
            return taskBox;
        }

        /// <summary>
        /// Создаем метку с датой события
        /// </summary>
        /// <param name="dateTimeEvent"></param>
        /// <returns></returns>
        private static Label CreateDateLabel(DateTime dateTimeEvent)
        {
            // Создаем метку для даты события
            return new Label
            {
                Text = $"{Resource.DateEvent}: {dateTimeEvent:dd.MM.yyyy HH:mm}",
                Location = new Point(10, 45),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right 
            };
        }

        // Метод для создания метки с описанием задачи
        private static Label CreateDescriptionLabel(string description)
        {
            // Создаем метку для описания задачи
            return new Label
            {
                Text = $"{Resource.Description}: {description}",
                Location = new Point(10, 20),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
        }

        // Метод для установки текста статуса в labelName
        public void InstallStatusLabel(int status)
        {
            // Устанавливаем текст статуса в labelName
            labelName.Text = status switch
            {
                1 => Resource.StatusToday,
                2 => Resource.StatusPlanned,
                3 => Resource.StatusAll,
                4 => Resource.StatusCompleted,
                _ => string.Empty, // Если статус неизвестный — пустой текст
            };
        }

        // Метод для создания кнопки "Обновить"
        private Button CreateUpdateButton(int todoId)
        {
            // Создаем кнопку "Обновить"
            var button = new Button
            {
                Text = Resource.Update,
                Location = new Point(10, 70),
                Tag = todoId,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Подключаем обработчик события нажатия на кнопку
            button.Click += UpdateTodoClicked;

            return button;
        }

        // Метод для создания кнопки "Закрыть"
        private Button CreateCloseButton(int todoId)
        {
            // Создаем кнопку "Закрыть"
            var button = new Button
            {
                Text = Resource.Close,
                Location = new Point(100, 70),
                Tag = todoId,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Подключаем обработчик события нажатия на кнопку
            button.Click += CloseTodoClicked;

            return button;
        }

        // Обработчик события нажатия на кнопку "Обновить"
        private void UpdateTodoClicked(object? sender, EventArgs e)
        {
            // Проверяем, что sender является кнопкой и содержит тег с идентификатором задачи
            if (sender is Button btn && btn.Tag is int id)
            {
                // Получаем задачу по идентификатору
                TodoItem item = _todo.GetTodoById(id);

                // Проверяем, что задача существует
                if (item != null)
                {
                    // Создаем и отображаем форму для обновления задачи
                    CreateOrUpdateToDo_Form updateToDo = new(item, _todo, false);

                    updateToDo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ошибка: Задача не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Обновляем список задач после обновления
                RefreshTodoList();
            }
        }

        // Обработчик события нажатия на кнопку "Закрыть"
        private void CloseTodoClicked(object? sender, EventArgs e)
        {
            // Проверяем, что sender является кнопкой и содержит тег с идентификатором задачи
            if (sender is Button btn && btn.Tag is int id)
            {
                // Закрываем задачу по идентификатору
                _todo.CloseTodoById(id);

                // Обновляем список задач после закрытия
                RefreshTodoList();
            }
        }

        // Метод для создания панели прокрутки
        private Panel CreateScrollPanel()
        {
            // Создаем панель прокрутки
            return new Panel
            {
                AutoScroll = true,
                Width = groupBoxUpdateTask.Width - 20,
                Height = groupBoxUpdateTask.Height - 50,
                Location = new Point(10, 40),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
        }

        // Обработчик события нажатия на кнопку "Закрыть"
        private void BtnCloseUpdateForm_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close(); 
        }

        /// <summary>
        /// Устанавливаем якоря для элементов управления
        /// </summary>
        /// <param name="parent"></param>
        private void SetAnchors(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is GroupBox || control is Panel)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else if (control is Button)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else if (control is Label)
                {
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }

                // Если внутри элемента тоже есть элементы (например, GroupBox содержит кнопки)
                if (control.HasChildren)
                {
                    SetAnchors(control);
                }
            }
        }
    }
}
