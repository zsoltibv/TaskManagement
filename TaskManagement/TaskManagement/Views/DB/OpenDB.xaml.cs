using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace TaskManagement.Views.DB
{
    /// <summary>
    /// Interaction logic for OpenDB.xaml
    /// </summary>
    public partial class OpenDB : Window
    {
        DBHelper dbHelper;
        public ObservableCollection<string> Databases { get; set; }
        private string SelectedItem { get; set; }
        public OpenDB(DBHelper helper)
        {
            InitializeComponent();
            dbHelper = helper;
            Databases = new ObservableCollection<string>(DBHelper.GetSavedFiles());
            this.DataContext = this;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                SelectedItem = (string)e.AddedItems[0];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dbHelper.LoadFromDB(SelectedItem);
            this.Close();
        }
    }
}
