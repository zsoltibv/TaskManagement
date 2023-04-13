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
using TaskManagement.ViewModels;
using TaskManagement.Views.Panels;

namespace TaskManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Panel1.Navigate(new TaskPanel(DataContext as TaskVM));
            Panel2.Navigate(new TreeViewPanel());
            Panel3.Navigate(new StatisticsPanel(DataContext as TaskVM));
            Panel4.Navigate(new TaskDescriptionPanel(DataContext as TaskVM));
        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {
            
        }

        private void Frame_Navigated_2(object sender, NavigationEventArgs e)
        {

        }

        private void Frame_Navigated_3(object sender, NavigationEventArgs e)
        {

        }

        private void Frame_Navigated_4(object sender, NavigationEventArgs e)
        {

        }
    }
}
