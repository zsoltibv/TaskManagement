using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.ViewModels
{
    class TaskViewModel
    {
        private ObservableCollection<Task> tasks;

        public TaskViewModel()
        {
            tasks = new ObservableCollection<Task>();
        }
    }
}
