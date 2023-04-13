using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.ViewModels
{
    public class TreeViewVM : BaseNotification
    {
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
            ItemsCollection.Add(new TreeViewElement
            {
                ItemName = "a",
                SubCollection = new ObservableCollection<TreeViewElement>()
                {
                    new TreeViewElement { ItemName = "b", SubCollection = new ObservableCollection<TreeViewElement>()
                    {
                        new TreeViewElement() { ItemName = "d", SubCollection = new ObservableCollection<TreeViewElement>() },
                        new TreeViewElement() { ItemName = "e", SubCollection = new ObservableCollection<TreeViewElement>() }
                    }
                    },
                    new TreeViewElement { ItemName = "c", SubCollection = new ObservableCollection<TreeViewElement>()
                    {
                        new TreeViewElement() { ItemName = "f", SubCollection = new ObservableCollection<TreeViewElement>() },
                        new TreeViewElement() { ItemName = "g", SubCollection = new ObservableCollection<TreeViewElement>() }
                    }
                    }
                }
            });
            ItemsCollection.Add(new TreeViewElement()
            {
                ItemName = "h",
                SubCollection = new ObservableCollection<TreeViewElement>()
                {
                    new TreeViewElement { ItemName = "i", SubCollection = new ObservableCollection<TreeViewElement>()
                    {
                        new TreeViewElement() { ItemName = "j", SubCollection = new ObservableCollection<TreeViewElement>() }
                    }
                    }
                }
            });
        }
    }
}
