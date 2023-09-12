using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeRidingABike.Classes
{
    internal class ToDoItem
    {
        public string Task { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }

        public ToDoItem(string task, DateTime? dueDate)
        {
            Task = task;
            DueDate = dueDate;
            CreationDate = DateTime.Now;
            Status = false;
        }
    }
}
