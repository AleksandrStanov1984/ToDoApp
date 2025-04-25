using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    internal interface ITodo
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool IsClose { get; set; }

        public int Count { get; set; }

        public bool IsDeleted { get; set; }

        public bool HasDeleted { get; set; }

        public bool Deleted { get; set; }

        bool SendToDoEmailEvent(string email, string subject, string body);
    }
}
