using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.ViewModels
{
    class TaskViewModel
    {
        public ObservableCollection<TaskElement> AllTasks { get; set; }
        public TaskViewModel()
        {

            AllTasks = new ObservableCollection<TaskElement>(){
                new TaskElement("Task 1", "Description 1", Status.Created,
                Priority.High, new DateTime(2023, 4, 6), new DateTime(2023, 4, 6), Category.Work)
            };
        }
    }
}
