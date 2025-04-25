using Todo.Enums;
using System.Data;
using DbLibrary.Models;
using ToDo = Todo.ToDo;
using TDTaskPriority = Todo.Enums.PriorityToDo;

namespace ToDoApp.Forms
{
    public partial class UpdateToDo_Form : Form
    {
        private readonly ToDo _todo;

        private readonly int _status;

        public UpdateToDo_Form(int status)
        {
            InitializeComponent();

            InstallStatusLabel(status);

            // Инициализируем класс ToDo
            _todo = new ToDo();

            // Проверяем статус задачи
            if (status < 1 || status > 4)
            {
                MessageBox.Show("Ошибка: Неверный статус задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Сохраняем переданный статус
            _status = status;

            // Заполняем ComboBox значениями приоритетов
            comboBoxPrioritySort.DataSource = Enum.GetValues(typeof(TDTaskPriority));
            comboBoxPrioritySort.SelectedItem = TDTaskPriority.Critical;

            // Подключаем обработчик события
            comboBoxPrioritySort.SelectedIndexChanged += ComboBoxPrioritySort_SelectedIndexChanged;

            // Отображаем задачи в groupBox
            DisplayGroupedTodosInGroupBox();
        }

        // Метод для отображения задач в groupBox с учетом статуса и сортировкой
        private void DisplayGroupedTodosInGroupBox(List<TodoItem>[] sortedTodos)
        {
            // Очищаем все старые элементы из groupBox
            groupBoxUpdateTask.Controls.Clear();

            // Создаем панель для прокрутки
            var scrollPanel = new Panel
            {
                AutoScroll = true,
                Width = groupBoxUpdateTask.Width - 20,
                Height = groupBoxUpdateTask.Height - 50,
                Location = new Point(10, 40) // Местоположение панели внутри groupBox
            };

            // Переменная для отступов между элементами
            int yOffset = 10;
            int groupBoxHeight = 100;
            int spacing = 10;

            // Статусные заголовки
            string[] statusHeaders = { "Сегодня", "В планах", "Все (кроме завершённых)", "Завершено" };

            // Отображаем задачи из отсортированных данных
            for (int i = 0; i < sortedTodos.Length; i++)
            {
                if (sortedTodos[i].Any()) // Если есть задачи для данного статуса
                {
                    var headerLabel = new Label
                    {
                        Text = statusHeaders[i],
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(10, yOffset),
                        AutoSize = true
                    };
                    scrollPanel.Controls.Add(headerLabel);
                    yOffset += headerLabel.Height + spacing;

                    foreach (var todo in sortedTodos[i])
                    {
                        // Получаем цвета для рамки и фона в зависимости от приоритета
                        var (borderColor, backgroundColor) = GetPriorityColors(todo.Priority);

                        var taskBox = new GroupBox
                        {
                            Text = todo.Title,
                            Width = scrollPanel.Width - 30,
                            Height = groupBoxHeight,
                            Location = new Point(10, yOffset),
                            Tag = todo.Id,
                            FlatStyle = FlatStyle.Flat
                        };

                        taskBox.ForeColor = borderColor;
                        taskBox.BackColor = backgroundColor;

                        var descriptionLabel = new Label
                        {
                            Text = $"Описание: {todo.Description}",
                            Location = new Point(10, 20),
                            AutoSize = true
                        };

                        var updateButton = new Button
                        {
                            Text = "Обновить",
                            Location = new Point(10, 50),
                            Tag = todo.Id
                        };

                        var closeButton = new Button
                        {
                            Text = "Закрыть",
                            Location = new Point(100, 50),
                            Tag = todo.Id
                        };

                        // Добавляем элементы в taskBox
                        taskBox.Controls.Add(descriptionLabel);
                        taskBox.Controls.Add(updateButton);
                        taskBox.Controls.Add(closeButton);

                        // Добавляем taskBox в scrollPanel
                        scrollPanel.Controls.Add(taskBox);

                        // Обновляем отступ для следующей задачи
                        yOffset += groupBoxHeight + spacing;
                    }
                }
            }

            // Добавляем панель с задачами в groupBoxUpdateTask
            groupBoxUpdateTask.Controls.Add(scrollPanel);
        }

        // Метод для создания заголовка статуса (Сегодня, В планах и т.д.)
        private Label CreateStatusHeaderLabel(string headerText, int yOffset)
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

        // Метод для создания TaskBox для каждой задачи
        private GroupBox CreateTaskGroupBox(TodoItem todo, int yOffset)
        {
            // Создаем GroupBox для задачи
            var taskBox = new GroupBox
            {
                Text = todo.Title,
                Width = 500, // Можно настроить под нужды
                Height = 80,
                Location = new Point(10, yOffset),
                Tag = todo.Id,
                FlatStyle = FlatStyle.Flat
            };

            // Получаем цвета в зависимости от приоритета
            var (borderColor, backgroundColor) = GetPriorityColors(todo.Priority);
            taskBox.ForeColor = borderColor;
            taskBox.BackColor = backgroundColor;

            // Создаем метку для описания задачи
            var descriptionLabel = new Label
            {
                Text = $"Описание: {todo.Description}",
                Location = new Point(10, 20),
                AutoSize = true
            };
            taskBox.Controls.Add(descriptionLabel);

            return taskBox;
        }


        // Метод для получения цветов в зависимости от приоритета
        private (Color borderColor, Color backgroundColor) GetPriorityColors(int priority)
        {
            // Определяем цвета в зависимости от приоритета
            return (priority) switch
            {
                (int)PriorityToDo.Low => (Color.Black, Color.DarkGray),
                (int)PriorityToDo.Medium => (Color.Green, Color.LightGreen),
                (int)PriorityToDo.High => (Color.Blue, Color.LightBlue),
                (int)PriorityToDo.Critical => (Color.Red, Color.LightCoral),
                _ => (Color.Black, Color.DarkGray), // default
            };
        }

        // Метод для создания кнопки "Обновить"
        private Button CreateUpdateButton(int todoId)
        {
            var button = new Button
            {
                Text = "Обновить",
                Location = new Point(10, 50),
                Tag = todoId
            };

            button.Click += UpdateTodoClicked;
            return button;
        }

        // Метод для создания кнопки "Закрыть"
        private Button CreateCloseButton(int todoId)
        {
            var button = new Button
            {
                Text = "Закрыть",
                Location = new Point(100, 50),
                Tag = todoId
            };

            button.Click += CloseTodoClicked;
            return button;
        }

        // Обработчик события нажатия на кнопку "Обновить"
        private void UpdateTodoClicked(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                var item = _todo.GetTodoById(id);
                //var updateForm = new UpdateTodoForm(item);
                //updateForm.ShowDialog();

                RefreshTodoList();
            }
        }

        // Обработчик события нажатия на кнопку "Закрыть"
        private void CloseTodoClicked(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                _todo.CloseTodoById(id);
                RefreshTodoList();
            }
        }

        // Метод для обновления списка задач
        private void RefreshTodoList()
        {
            var selectedPriority = (TDTaskPriority)comboBoxPrioritySort.SelectedItem;
            var grouped = _todo.GetToDoList();
            var sorted = SortTodosByPriority(grouped, selectedPriority);
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
            for (int i = 0; i < result.Length; i++)
                result[i] = new List<TodoItem>();

            result[_status - 1] = filteredTodos;
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
            groupBoxUpdateTask.Controls.Clear();

            var scrollPanel = new Panel
            {
                AutoScroll = true,
                Width = groupBoxUpdateTask.Width - 20,
                Height = groupBoxUpdateTask.Height - 50,
                Location = new Point(10, 40)
            };

            List<TodoItem>[] groupedTodos = _todo.GetToDoList();

            if (_status < 1 || _status > groupedTodos.Length)
                return;

            var todos = groupedTodos[_status - 1]
                .OrderByDescending(todo => todo.Priority == (int)PriorityToDo.Critical)
                .ThenBy(todo => todo.Priority)
                .ToList();

            string[] statusHeaders = { "Сегодня", "В планах", "Все (кроме завершённых)", "Завершено" };

            int yOffset = 10;
            int groupBoxHeight = 90;
            int spacing = 10;

            foreach (var todo in todos)
            {
                Color borderColor = Color.Gray;
                Color backgroundColor = Color.LightGray;

                switch ((PriorityToDo)todo.Priority)
                {
                    case PriorityToDo.Low:
                        borderColor = Color.Black;
                        backgroundColor = Color.DarkGray;
                        break;
                    case PriorityToDo.Medium:
                        borderColor = Color.Green;
                        backgroundColor = Color.LightGreen;
                        break;
                    case PriorityToDo.High:
                        borderColor = Color.Blue;
                        backgroundColor = Color.LightBlue;
                        break;
                    case PriorityToDo.Critical:
                        borderColor = Color.Red;
                        backgroundColor = Color.LightCoral;
                        break;
                }

                var taskBox = new GroupBox
                {
                    Text = todo.Title,
                    Width = scrollPanel.Width - 30,
                    Height = groupBoxHeight,
                    Location = new Point(10, yOffset),
                    Tag = todo.Id,
                    BackColor = backgroundColor,
                    ForeColor = borderColor
                };

                var descriptionLabel = new Label
                {
                    Text = $"Описание: {todo.Description}",
                    Location = new Point(10, 20),
                    AutoSize = true
                };

                var updateButton = new Button
                {
                    Text = "Обновить",
                    Location = new Point(10, 50),
                    Tag = todo.Id
                };
                //updateButton.Click += (s, e) =>
                //{
                //    var item = _todo.GetTodoById(todo.Id);
                //    var updateForm = new UpdateTodoForm(item);
                //    updateForm.ShowDialog();
                //    DisplayGroupedTodosInGroupBox(); // Обновляем список после редактирования
                //};

                var closeButton = new Button
                {
                    Text = "Закрыть",
                    Location = new Point(100, 50),
                    Tag = todo.Id
                };
                closeButton.Click += (s, e) =>
                {
                    _todo.CloseTodoById(todo.Id);
                    DisplayGroupedTodosInGroupBox();
                };

                taskBox.Controls.Add(descriptionLabel);
                taskBox.Controls.Add(updateButton);
                taskBox.Controls.Add(closeButton);

                scrollPanel.Controls.Add(taskBox);
                yOffset += groupBoxHeight + spacing;
            }

            groupBoxUpdateTask.Controls.Add(scrollPanel);
        }

        // Метод для установки текста статуса в labelName
        public void InstallStatusLabel(int status)
        {
            switch (status)
            {
                case 1:
                    labelName.Text = "Сегодня";
                    break;
                case 2:
                    labelName.Text = "В планах";
                    break;
                case 3:
                    labelName.Text = "Все";
                    break;
                case 4:
                    labelName.Text = "Завершино";
                    break;
                default:
                    break;
            }
        }

        // Обработчик события нажатия на кнопку "Закрыть"
        private void BtnCloseUpdateForm_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
