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
using TaskManagement.Services;

namespace TaskManagement.Views.TDL
{
    /// <summary>
    /// Interaction logic for AddSubTDL.xaml
    /// </summary>
    public partial class AddSubTDL : Window
    {
        TreeViewHelper tdl;
        public AddSubTDL(TreeViewHelper tdl)
        {
            InitializeComponent();
            this.tdl = tdl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var text = TextBox.Text;
            tdl.AddSubTdl(text);
            this.Close();
        }
    }
}
