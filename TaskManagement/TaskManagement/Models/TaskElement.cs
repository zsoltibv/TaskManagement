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
                NotifyPropertyChanged("Name");
            }
        }
        private string _description = "";
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        private Enums.Status _status;
        public Enums.Status Status
        {
            get { return _status; }
            set
            {
                _status = value;
                NotifyPropertyChanged("Status");
            }
        }

        private Enums.Priority _priority;
        public Enums.Priority Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                NotifyPropertyChanged("Priority");
            }
        }

        private DateTime _deadline;
        public DateTime Deadline
        {
            get { return _deadline; }
            set
            {
                _deadline = value;
                NotifyPropertyChanged("Deadline");
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                NotifyPropertyChanged("EndDate");
            }
        }

        private Enums.Category _category;
        public Enums.Category Category
        {
            get { return _category; }
            set
            {
                _category = value;
                NotifyPropertyChanged("Category");
            }
        }

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
