using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services
{
    public class StatsHelper
    {
        private ObservableCollection<TreeViewElement> items { get; set; }
        public StatsHelper(ObservableCollection<TreeViewElement> items)
        {
            this.items = items;
        }
    }
}
