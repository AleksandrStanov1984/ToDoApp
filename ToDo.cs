using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Todo.Enums;
using TDExeption = Todo.ToDoException;
using TDSendEmail = Todo.ToDoSenderEmail;
using TDTaskStatus = Todo.Enums.TaskStatus;

namespace Todo
{
    public class ToDo : IToDo
    {
        public int Id { get; set; }

        public string Author { get; set; } = string.Empty; // Initialize with a default value  

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool IsClose { get; set; }

        public int Count { get; set; }

        public bool IsDeleted { get; set; }

        public bool HasDeleted { get; set; }

        public bool Deleted { get; set; }

        public TDSendEmail toDoSendEmail = new();

        public ToDo() { }

        public ToDo(int _id)
        {
            Id = _id;
            Author = "Author";
        }

        public TDTaskStatus ListViewHitInfo(TDTaskStatus taskStatus)
        {
            return taskStatus;
        }

        public bool SendToDoEMailEvent(string subject, string body)
        {
            try
            {
                if (toDoSendEmail.SendEmail(subject, body))
                    MessageBox.Show("?????? ?????????? ???????!");
                else
                    MessageBox.Show("?????? ????????: ");
            }
            catch (Exception ex)
            {
                throw new TDExeption("?????? ???????? ??????" + ex.Message);
            }

            return true;
        }
    }
}
