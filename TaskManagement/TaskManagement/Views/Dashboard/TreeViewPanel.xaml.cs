using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using TaskManagement.Models;
using TaskManagement.ViewModels;

namespace TaskManagement.Views.Panels
{
    /// <summary>
    /// Interaction logic for TreeViewPanel.xaml
    /// </summary>
    public partial class TreeViewPanel : Page
    {
        public TreeViewPanel(ToDoListVM dataContext)
        {
            InitializeComponent();
            DataContext = dataContext;
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewElement? selectedItem = treeView.SelectedItem as TreeViewElement;
            if (selectedItem != null)
            {
                (DataContext as ToDoListVM).TreeViewVM.CurrentItem = selectedItem;
            }
        }
    }
}
