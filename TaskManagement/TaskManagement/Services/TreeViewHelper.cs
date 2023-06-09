﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Views.TDL;
using TaskManagement.Views.Task;
using TaskManagement.Views.About;
using static TaskManagement.Models.Enums;
using System.Windows;
using TaskManagement.ViewModels;
using System.Xml.Linq;
using System.Windows.Documents;

namespace TaskManagement.Services
{
    public class TreeViewHelper
    {
        ToDoListVM tdlVM;
        private ObservableCollection<TreeViewElement> items { get; set; }
        private TreeViewElement currentItem;

        public TreeViewHelper(ObservableCollection<TreeViewElement> items, ToDoListVM tdlVM)
        {
            this.tdlVM = tdlVM;
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

        public void MoveUpTdl(TreeViewElement element)
        {
            int index = items.IndexOf(element);
            if (index - 1 >= 0)
            {
                items.Move(index, index - 1);
            }
        }

        public void MoveDownTdl(TreeViewElement element)
        {
            int index = items.IndexOf(element);
            if (index + 1 <= items.Count)
            {
                items.Move(index, index + 1);
            }
        }

        public void MoveUpTask(TaskElement element)
        {
            int index = currentItem.SubCollectionTask.IndexOf(element);
            if (index - 1 >= 0)
            {
                currentItem.SubCollectionTask.Move(index, index - 1);
            }
        }

        public void MoveDownTask(TaskElement element)
        {
            int index = currentItem.SubCollectionTask.IndexOf(element);
            if (index + 1 <= currentItem.SubCollectionTask.Count)
            {
                currentItem.SubCollectionTask.Move(index, index + 1);
            }
        }

        public void SetDoneTask(TaskElement element)
        {
            element.Status = Enums.Status.Done;
            tdlVM.StatsVM.UpdateStats();
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
            tdlVM.StatsVM.UpdateStats();
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

                objectToDelete = innerList.SubCollectionTask.FirstOrDefault(x => x.Id == task.Id);

                if (objectToDelete != null)
                {
                    // remove the object from the inner list
                    innerList.SubCollectionTask.Remove(objectToDelete);
                    break;
                }

                foreach (var innerList2 in innerList.SubCollectionTDL)
                {
                    objectToDelete = innerList2.SubCollectionTask.FirstOrDefault(x => x.Id == task.Id);

                    if (objectToDelete != null)
                    {
                        // remove the object from the inner list
                        innerList2.SubCollectionTask.Remove(objectToDelete);
                        break;
                    }
                }
            }
            tdlVM.StatsVM.UpdateStats();
        }

        public void DeleteTdl(TreeViewElement element)
        {
            TreeViewElement objectToDelete = items.FirstOrDefault(x => x.Id == element.Id);

            if (objectToDelete != null)
            {
                // remove the object from the inner list
                items.Remove(objectToDelete);
                return;
            }

            foreach (var innerList in items)
            {
                objectToDelete = innerList.SubCollectionTDL.FirstOrDefault(x => x.Id == element.Id);

                if (objectToDelete != null)
                {
                    // remove the object from the inner list
                    innerList.SubCollectionTDL.Remove(objectToDelete);
                    break;
                }
            }
        }

        public void About(TaskElement element)
        {
            About about = new About();
            about.ShowDialog();
        }

        public void SortDeadline(TreeViewElement element)
        {
            this.currentItem = element;
            var list = currentItem.SubCollectionTask.OrderBy(x => x.Deadline).ToList();
            currentItem.SubCollectionTask.Clear();
            foreach (var item in list)
            {
                currentItem.SubCollectionTask.Add(item);
            }
        }

        public void SortPriority(TreeViewElement element)
        {
            this.currentItem = element;
            var list = currentItem.SubCollectionTask.OrderBy(x => x.Priority).ToList();
            currentItem.SubCollectionTask.Clear();
            foreach (var item in list)
            {
                currentItem.SubCollectionTask.Add(item);
            }
        }
    }
}
