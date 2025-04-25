using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoApp.Forms
{
    public partial class UpdateToDo_Form : Form
    {
        public UpdateToDo_Form(int status)
        {
            InitializeComponent();

            InstallStatusLabel(status);
            // TODO: вытянуть с базы записи и динамически создать список с кнопкой обновить
            // обновление вывести только для того стаса с которого открыли форму

        }

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

        private void BtnCloseUpdateForm_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрывает текущую форму
        }
    }
}
