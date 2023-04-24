using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TreeViewElement : BaseNotification
    {
        public TreeViewElement()
        {
            SubCollectionTDL = new ObservableCollection<TreeViewElement>();
            SubCollectionTask = new ObservableCollection<TaskElement>();
        }
        public ObservableCollection<TreeViewElement> SubCollectionTDL { get; set; }
        public ObservableCollection<TaskElement> SubCollectionTask { get; set; }
        private string itemName;
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
                NotifyPropertyChanged("ItemName");
            }
        }
    }
}
