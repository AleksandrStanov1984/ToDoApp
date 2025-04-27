using DbLibrary.Models;
using ToDo = Todo.ToDo;
using TodoItem = DbLibrary.Models.TodoItem;
using TDTaskPriority = Todo.Enums.PriorityToDo;

namespace ToDoApp.Forms;

public partial class CreateOrUpdateToDo_Form : Form
{
    /// <summary>
    /// Создаем экземпляр класса Todo
    /// </summary>
    public ToDo _todo;

    /// <summary>
    /// Создаем экземпляр класса TodoItem
    /// <summary>
    private readonly TodoItem _todoItem;

    private bool _isCreate = true;

    /// <summary>
    /// Constructor for UpdateToDo_Form
    /// </summary>
    public CreateOrUpdateToDo_Form()
    {
        // Инициализируем компоненты формы
        InitializeComponent();

        // Создаем экземпляр класса ToDo
        _todo = new ToDo();

        // Устанавливаем начальное значение для ComboBox
        SetValueToComboBoxPriority();
    }

    /// <summary>
    /// Constructor for UpdateToDo_Form with TodoItem
    /// </summary>
    /// <param name="todoItemInstance"></param>
    /// <param name="todoInstance"></param>
    /// <param name="isCreate"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public CreateOrUpdateToDo_Form(TodoItem todoItemInstance, ToDo todoInstance, bool isCreate)
    {
        // Инициализируем компоненты формы
        InitializeComponent();

        // Инициализируем класс TodoItem
        _todoItem = todoItemInstance ?? throw new ArgumentNullException(nameof(todoItemInstance));

        _todo = todoInstance ?? throw new ArgumentNullException(nameof(todoInstance));

        _isCreate = isCreate;

        if (_todoItem != null)
        {
            SetValueOfFields(_todoItem);

            // Устанавливаем начальное значение для ComboBox
            // Устанавливаем начальное значение для ComboBox
            SetValueToComboBoxPriority();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void SetValueToComboBoxPriority()
    {
        // Устанавливаем начальное значение для ComboBox
        comboBoxPriority.DataSource = Enum.GetValues(typeof(TDTaskPriority));
    }

    /// <summary>
    /// Устанавливаем значения полей формы
    /// </summary>
    /// <param name="todoItem"></param>
    private void SetValueOfFields(TodoItem todoItem)
    {
        // Устанавливаем значения полей формы на основе переданного объекта TodoItem
        textBoxThema.Text = todoItem.Title;
        textBoxDescription.Text = todoItem.Description;
        comboBoxPriority.SelectedItem = (TDTaskPriority)todoItem.Priority;
        dateTimePickerEvent.Value = todoItem.DateTimeEvent;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CreateNewToDo_Form_Load(object sender, EventArgs e)
    {
        // Устанавливаем начальное значение для dateTimePicker
        dateTimePickerEvent.MinDate = DateTime.Now; /// TODO + 8 hours
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSaveNewToDo_Click(object sender, EventArgs e)
    {
        // Проверяем, что выбранный элемент ComboBox является значением перечисления TDTaskPriority
        if (comboBoxPriority.SelectedItem is TDTaskPriority)
        {
            // Получаем выбранный элемент из ComboBox (предположим, что это значение как строка или целое число)
            int selectedPriorityInt = (int)comboBoxPriority.SelectedItem;

            // Обновляем поля обьекта TodoItem
            _todoItem.Title = textBoxThema.Text;
            _todoItem.Description = textBoxDescription.Text;
            _todoItem.Priority = selectedPriorityInt;
            _todoItem.DateTimeEvent = dateTimePickerEvent.Value;
            _todoItem.Status = ToDo.CheckDateStatusAsInt(dateTimePickerEvent.Value);
            _todoItem.Updated = DateTime.UtcNow;

            try
            {
                if (!_isCreate) {
                    // Обновляем задачу с помощью метода UpdateToDo
                    _todo.UpdateToDo(_todoItem);
                }
                else
                {
                    // Создаем новую задачу с помощью метода CreateAddToDoEvent
                    _todo.CreateAddToDoEvent
                        (
                        textBoxThema.Text,
                        textBoxDescription.Text,
                        selectedPriorityInt,
                        dateTimePickerEvent.Value
                        );
                }
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

        // Закрываем форму после создания задачи
        Close();
    }

    /// <summary>
    /// Закрывает текущую форму
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCencelAndCloseForm_Click(object sender, EventArgs e)
    {
        Close();   
    }
}
