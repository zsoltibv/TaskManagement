using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskManagement.Models;
using TaskManagement.ViewModels;

namespace TaskManagement.Views.Panels
{
    /// <summary>
    /// Interaction logic for TaskPanel.xaml
    /// </summary>
    public partial class TaskPanel : Page
    {
        public TaskPanel(ToDoListVM dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }

        private void OnTaskClick(object sender, SelectionChangedEventArgs e)
        {
            // get the selected item
            TaskElement? selectedTask = taskListView.SelectedItem as TaskElement;

            // check if a task was selected
            if (selectedTask != null)
            {
                // navigate to the other page and pass the text as a parameter
                //TaskDescriptionPanel panel4 = (TaskDescriptionPanel)((MainWindow)Application.Current.MainWindow).Panel4.Content;
                //panel4.SetDescription(selectedTask.Description);
                (DataContext as ToDoListVM).TaskVM.SelectedTaskDescription = selectedTask.Description;
            }
        }
    }
}
