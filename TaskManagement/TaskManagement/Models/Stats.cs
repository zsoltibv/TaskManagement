using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Stats : BaseNotification
    {
        private int _tasksDue = 0;
        public int TasksDue
        {
            get { return _tasksDue; }
            set
            {
                _tasksDue = value;
                NotifyPropertyChanged("TasksDue");
            }
        }

        private int _tasksDueTomorrow = 0;
        public int TasksDueTomorrow
        {
            get { return _tasksDueTomorrow; }
            set
            {
                _tasksDueTomorrow = value;
                NotifyPropertyChanged("TasksDueTomorrow");
            }
        }

        private int _tasksOverdue = 0;
        public int TasksOverdue
        {
            get { return _tasksOverdue; }
            set
            {
                _tasksOverdue = value;
                NotifyPropertyChanged("TasksOverdue");
            }
        }

        private int _tasksDone = 0;
        public int TasksDone
        {
            get { return _tasksDone; }
            set
            {
                _tasksDone = value;
                NotifyPropertyChanged("TasksDone");
            }
        }

        private int _tasksToBeDone = 0;
        public int TasksToBeDone
        {
            get { return _tasksToBeDone; }
            set
            {
                _tasksToBeDone = value;
                NotifyPropertyChanged("TasksToBeDone");
            }
        }
    }
}
