using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TaskManagement.Commands;
using TaskManagement.Models;
using TaskManagement.Services;

namespace TaskManagement.ViewModels
{
    public class TreeViewVM : BaseNotification
    {
        public TreeViewHelper tdl;
        public DBHelper dbHelper;

        private TaskElement _selectedTask;
        public TaskElement SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                _selectedTask = value;
                NotifyPropertyChanged("SelectedTask");
            }
        }
        private TreeViewElement _currentItem;
        public TreeViewElement CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
                NotifyPropertyChanged("CurrentItem");
            }
        }
        public ObservableCollection<TreeViewElement> ItemsCollection { get; set; }

        public TreeViewVM()
        {
            ItemsCollection = new ObservableCollection<TreeViewElement>();
            tdl = new TreeViewHelper(ItemsCollection);
            dbHelper = new DBHelper(ItemsCollection);
        }

        private ICommand _addRootTDLCommand;
        public ICommand AddRootTDLCommand
        {
            get
            {
                if (_addRootTDLCommand == null)
                {
                    _addRootTDLCommand = new RelayCommand<TreeViewElement>(tdl.ShowAddTdlDialog);
                }
                return _addRootTDLCommand;
            }
        }

        private ICommand _addTaskCommand;
        public ICommand AddTaskCommand
        {
            get
            {
                if (_addTaskCommand == null)
                {
                    _addTaskCommand = new RelayCommand<TreeViewElement>(tdl.ShowAddTaskDialog);
                }
                return _addTaskCommand;
            }
        }
        private ICommand _deleteTaskCommand;
        public ICommand DeleteTaskCommand
        {
            get
            {
                if (_deleteTaskCommand == null)
                {
                    _deleteTaskCommand = new RelayCommand<TaskElement>(tdl.DeleteTask);
                }
                return _deleteTaskCommand;
            }
        }

        private ICommand _addSubTDLCommand;
        public ICommand AddSubTDLCommand
        {
            get
            {
                if (_addSubTDLCommand == null)
                {
                    _addSubTDLCommand = new RelayCommand<TreeViewElement>(tdl.ShowAddSubTdlDialog);
                }
                return _addSubTDLCommand;
            }
        }

        private ICommand _deleteTDLCommand;
        public ICommand DeleteTDLCommand
        {
            get
            {
                if (_deleteTDLCommand == null)
                {
                    _deleteTDLCommand = new RelayCommand<TreeViewElement>(tdl.DeleteTdl);
                }
                return _deleteTDLCommand;
            }
        }

        private ICommand _moveUpTDLCommand;
        public ICommand MoveUpTDLCommand
        {
            get
            {
                if (_moveUpTDLCommand == null)
                {
                    _moveUpTDLCommand = new RelayCommand<TreeViewElement>(tdl.MoveUpTdl);
                }
                return _moveUpTDLCommand;
            }
        }

        private ICommand _moveDownTDLCommand;
        public ICommand MoveDownTDLCommand
        {
            get
            {
                if (_moveDownTDLCommand == null)
                {
                    _moveDownTDLCommand = new RelayCommand<TreeViewElement>(tdl.MoveDownTdl);
                }
                return _moveDownTDLCommand;
            }
        }

        private ICommand _moveUpTaskCommand;
        public ICommand MoveUpTaskCommand
        {
            get
            {
                if (_moveUpTaskCommand == null)
                {
                    _moveUpTaskCommand = new RelayCommand<TaskElement>(tdl.MoveUpTask);
                }
                return _moveUpTaskCommand;
            }
        }
        private ICommand _moveDownTaskCommand;
        public ICommand MoveDownTaskCommand
        {
            get
            {
                if (_moveDownTaskCommand == null)
                {
                    _moveDownTaskCommand = new RelayCommand<TaskElement>(tdl.MoveDownTask);
                }
                return _moveDownTaskCommand;
            }
        }
        private ICommand _setDoneTaskCommand;
        public ICommand SetDoneTaskCommand
        {
            get
            {
                if (_setDoneTaskCommand == null)
                {
                    _setDoneTaskCommand = new RelayCommand<TaskElement>(tdl.SetDoneTask);
                }
                return _setDoneTaskCommand;
            }
        }
        private ICommand _aboutCommand;
        public ICommand AboutCommand
        {
            get
            {
                if (_aboutCommand == null)
                {
                    _aboutCommand = new RelayCommand<TaskElement>(tdl.About);
                }
                return _aboutCommand;
            }
        }
        private ICommand _addToDB;
        public ICommand AddToDB
        {
            get
            {
                if (_addToDB == null)
                {
                    _addToDB = new RelayCommand<TreeViewElement>(dbHelper.SaveToDB);
                }
                return _addToDB;
            }
        }
        private ICommand _openDB;
        public ICommand OpenDB
        {
            get
            {
                if (_openDB == null)
                {
                    _openDB = new RelayCommand<TreeViewElement>(dbHelper.OpenDB);
                }
                return _openDB;
            }
        }
    }
}
