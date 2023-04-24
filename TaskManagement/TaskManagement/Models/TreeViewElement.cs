﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskManagement.Models.Enums;

namespace TaskManagement.Models
{
    public class TreeViewElement : BaseNotification
    {
        public TreeViewElement()
        {
            SubCollectionTDL = new ObservableCollection<TreeViewElement>();
            SubCollectionTask = new ObservableCollection<TaskElement>();
        }
        private ObservableCollection<TreeViewElement> _subCollectionTDL;
        public ObservableCollection<TreeViewElement> SubCollectionTDL
        {
            get { return _subCollectionTDL; }
            set
            {
                _subCollectionTDL = value;
                NotifyPropertyChanged("SubCollectionTDL");
            }
        }
        private ObservableCollection<TaskElement> _subCollectionTask;
        public ObservableCollection<TaskElement> SubCollectionTask
        {
            get { return _subCollectionTask; }
            set
            {
                _subCollectionTask = value;
                NotifyPropertyChanged("SubCollectionTask");
            }
        }

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
