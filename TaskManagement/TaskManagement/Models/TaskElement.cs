using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Models
{
    public class TaskElement : BaseNotification
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("name");
            }
        }

        public string Description { get; set; } = "";

        public Enums.Status Status { get; set; }

        public Enums.Priority Priority { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime EndDate { get; set; }

        public Enums.Category Category { get; set; }

        public TaskElement() { }

        public TaskElement(string name, string description, Enums.Status status, Enums.Priority priority, DateTime deadline, DateTime endDate, Enums.Category category)
        {
            Name = name;
            Description = description;
            Status = status;
            Priority = priority;
            Deadline = deadline;
            EndDate = endDate;
            Category = category;
        }
    }
}
