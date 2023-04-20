using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Views.TDL;

namespace TaskManagement.Services
{
    public class TDLOperations
    {
        private ObservableCollection<TreeViewElement> items { get; set; }

        public TDLOperations(ObservableCollection<TreeViewElement> items) {
            this.items = items;
        }

        public void ShowAddTdlDialog(TreeViewElement element)
        {
            AddRootTDL addRootTDL = new AddRootTDL(this);
            addRootTDL.ShowDialog();
        }

        public void AddRootTdl(string name)
        {
            items.Add(new TreeViewElement
            {
                ItemName = name,
            });
        }
    }
}
