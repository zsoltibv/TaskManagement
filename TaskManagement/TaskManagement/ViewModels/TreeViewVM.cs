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
        TDLOperations tdl;
        public ObservableCollection<TreeViewElement> items { get; set; }
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
        public TreeViewVM(TDLOperations tdl)
        {
            this.tdl = tdl;
        }
    }
}
