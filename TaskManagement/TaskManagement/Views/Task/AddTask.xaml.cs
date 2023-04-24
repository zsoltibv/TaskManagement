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
using System.Windows.Shapes;
using TaskManagement.Models;
using TaskManagement.Services;
using TaskManagement.ViewModels;

namespace TaskManagement.Views.Task
{
    /// <summary>
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        TreeViewHelper tdl;
        public AddTask(TreeViewHelper tdl)
        {
            InitializeComponent();
            this.tdl = tdl;
            comboStatus.ItemsSource = Enum.GetValues(typeof(Enums.Status));
            comboStatus.SelectedIndex = 0;
            comboPriority.ItemsSource = Enum.GetValues(typeof(Enums.Priority));
            comboPriority.SelectedIndex = 0;
            comboCategory.ItemsSource = Enum.GetValues(typeof(Enums.Category));
            comboCategory.SelectedIndex = 0;
            dateDeadline.Text = DateTime.Now.ToString("24.04.2023");
            dateEndDate.Text = DateTime.Now.ToString("27.04.2023");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = nameTextBox.Text;
            var description = descTextBox.Text;
            var status = (Enums.Status)comboStatus.SelectedItem;
            var priority = (Enums.Priority)comboPriority.SelectedItem;
            var category = (Enums.Category)comboCategory.SelectedItem;
            var deadLine = dateDeadline.SelectedDate;
            var endDate = dateEndDate.SelectedDate;

            tdl.AddTask(name, description, status, priority, category, (DateTime)deadLine, (DateTime)endDate);
            this.Close();
        }
    }
}
