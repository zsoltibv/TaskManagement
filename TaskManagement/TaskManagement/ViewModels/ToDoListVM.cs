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

namespace TaskManagement.ViewModels
{
    public class ToDoListVM
    {
        private TDLOperations tdl;
        public ObservableCollection<TreeViewElement> ItemsCollection { get; set; }

        public ToDoListVM()
        {
            ItemsCollection = new ObservableCollection<TreeViewElement>();
            tdl = new TDLOperations(ItemsCollection);
        }

        private ICommand addRootTDLCommand;
        public ICommand AddRootTDLCommand
        {
            get
            {
                if (addRootTDLCommand == null)
                {
                    addRootTDLCommand = new RelayCommand<TreeViewElement>(tdl.ShowAddTdlDialog);
                }
                return addRootTDLCommand;
            }
        }
    }
}
