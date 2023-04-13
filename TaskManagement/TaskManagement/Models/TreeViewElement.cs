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
            SubCollection = new ObservableCollection<TreeViewElement>();
        }
        public ObservableCollection<TreeViewElement> SubCollection { get; set; }
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
