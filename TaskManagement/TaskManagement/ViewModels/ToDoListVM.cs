using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Services;
using TaskManagement.Models;
using System.Windows.Input;
using TaskManagement.Commands;
using System.Windows.Documents;
using System.Collections.ObjectModel;
using TaskManagement.Views.Panels;

namespace TaskManagement.ViewModels
{
    public class ToDoListVM : BaseNotification
    {
        public TreeViewVM TreeViewVM { get; set; }

        public StatsVM StatsVM { get; set; }
        
        public ToDoListVM()
        {
            TreeViewVM = new TreeViewVM();
            StatsVM = new StatsVM();
        }
    }
}
