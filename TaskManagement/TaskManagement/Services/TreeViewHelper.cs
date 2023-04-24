using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Views.TDL;
using TaskManagement.Views.Task;
using static TaskManagement.Models.Enums;
using System.Windows;
using TaskManagement.ViewModels;

namespace TaskManagement.Services
{
    public class TreeViewHelper
    {
        private ObservableCollection<TreeViewElement> items { get; set; }
        private TreeViewElement currentItem;

        public TreeViewHelper(ObservableCollection<TreeViewElement> items)
        {
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

        public void ShowAddTaskDialog(TreeViewElement element)
        {
            //change
            this.currentItem = element;
            //MessageBox.Show(element.ItemName.ToString());
            AddTask addTask = new AddTask(this);
            addTask.ShowDialog();
        }

        public void AddTask(string name, string description, Enums.Status status, Enums.Priority priority, Enums.Category category, DateTime deadLine, DateTime endDate)
        {
            if (currentItem == null)
            {
                MessageBox.Show("No TDL selected!");
            }
            else
            {
                if (currentItem.SubCollectionTask == null)
                {
                    currentItem.SubCollectionTask = new ObservableCollection<TaskElement>()
                    {
                        new TaskElement(name, description, status, priority, deadLine, endDate, category)
                    };
                }
                else
                {
                    currentItem.SubCollectionTask.Add(new TaskElement(name, description, status, priority, deadLine, endDate, category));
                }
            }
        }
    }
}
