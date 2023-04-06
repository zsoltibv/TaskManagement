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

namespace TaskManagement.Views.Panels
{
    /// <summary>
    /// Interaction logic for TaskDescriptionPanel.xaml
    /// </summary>
    public partial class TaskDescriptionPanel : Page
    {
        public TaskDescriptionPanel()
        {
            InitializeComponent();
        }

        public void SetDescription(string taskDescription)
        {
            TaskDescriptionInput.Text = taskDescription;
        }
    }
}
