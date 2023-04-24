using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TaskManagement.Commands;
using TaskManagement.Models;
using TaskManagement.Services;

namespace TaskManagement.ViewModels
{
    public class TreeViewVM : BaseNotification
    {
        public TreeViewHelper tdl;
        private TreeViewElement currentItem;
        public TreeViewElement CurrentItem
        {
            get
            {
                return currentItem;
            }
            set
            {
                currentItem = value;
                NotifyPropertyChanged("CurrentItem");
            }
        }
        public ObservableCollection<TreeViewElement> ItemsCollection { get; set; }

        public TreeViewVM()
        {
            ItemsCollection = new ObservableCollection<TreeViewElement>();
            tdl = new TreeViewHelper(ItemsCollection);
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

        private ICommand addTaskCommand;
        public ICommand AddTaskCommand
        {
            get
            {
                if (addTaskCommand == null)
                {
                    addTaskCommand = new RelayCommand<TreeViewElement>(tdl.ShowAddTaskDialog);
                }
                return addTaskCommand;
            }
        }
    }
}
