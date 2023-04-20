using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TaskManagement.Commands;
using TaskManagement.Models;
using TaskManagement.Services;

namespace TaskManagement.ViewModels
{
    public class TreeViewVM : BaseNotification
    {
        TreeViewHelper tdl;
        public ObservableCollection<TreeViewElement> ItemsCollection { get; set; }

        private TreeViewElement selectedItem;
        public TreeViewElement SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }
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
    }
}
