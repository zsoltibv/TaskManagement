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
using System.Xml.Linq;

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
            this.currentItem = element;
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

        public void ShowAddSubTdlDialog(TreeViewElement element)
        {
            this.currentItem = element;
            AddSubTDL addSubTDL = new AddSubTDL(this);
            addSubTDL.ShowDialog();
        }

        public void AddSubTdl(string name)
        {
            if (currentItem == null)
            {
                MessageBox.Show("No TDL selected!");
            }
            else
            {
                currentItem.SubCollectionTDL = new ObservableCollection<TreeViewElement>()
                {
                    new TreeViewElement()
                    {
                        ItemName = name,
                    }
                };
            }
        }

        public void DeleteTask(TaskElement task)
        {
            // find the object you want to delete
            TaskElement objectToDelete = null;

            foreach (var innerList in items)
            {

                objectToDelete = innerList.SubCollectionTask.FirstOrDefault(x => x.Name == task.Name);

                if (objectToDelete != null)
                {
                    // remove the object from the inner list
                    innerList.SubCollectionTask.Remove(objectToDelete);
                    break;
                }

                foreach (var innerList2 in innerList.SubCollectionTDL)
                {
                    objectToDelete = innerList2.SubCollectionTask.FirstOrDefault(x => x.Name == task.Name);

                    if (objectToDelete != null)
                    {
                        // remove the object from the inner list
                        innerList2.SubCollectionTask.Remove(objectToDelete);
                        break;
                    }
                }
            }
        }

        public void DeleteTdl(TreeViewElement element)
        {
            TreeViewElement objectToDelete = items.FirstOrDefault(x => x.ItemName == element.ItemName);

            if (objectToDelete != null)
            {
                // remove the object from the inner list
                items.Remove(objectToDelete);
                return;
            }

            foreach (var innerList in items)
            {
                objectToDelete = innerList.SubCollectionTDL.FirstOrDefault(x => x.ItemName == element.ItemName);

                if (objectToDelete != null)
                {
                    // remove the object from the inner list
                    innerList.SubCollectionTDL.Remove(objectToDelete);
                    break;
                }
            }
        }
    }
}
