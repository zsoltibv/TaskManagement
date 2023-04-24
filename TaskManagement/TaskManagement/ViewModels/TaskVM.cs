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
    public class TaskVM : BaseNotification
    {
        public ObservableCollection<TaskElement> AllTasks { get; set; }
        private string selectedTaskDescription;
        public string SelectedTaskDescription 
        { 
            get
            {
                return selectedTaskDescription;
            }
            set
            {
                selectedTaskDescription = value;
                NotifyPropertyChanged("SelectedTaskDescription");
            }
        }
        public TaskVM()
        {

            AllTasks = new ObservableCollection<TaskElement>(){
                new TaskElement("Task 1", "Description 1", Enums.Status.Created,
                Enums.Priority.High, new DateTime(2023, 4, 6), new DateTime(2023, 4, 6), Enums.Category.Work)
            };
        }
    }
}
