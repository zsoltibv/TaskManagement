using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.ViewModels
{
    class AddTask
    {
        private ObservableCollection<Task> tasks;

        public AddTask()
        {
            tasks = new ObservableCollection<Task>();
        }
    }
}
