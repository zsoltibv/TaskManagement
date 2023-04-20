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
    /// Interaction logic for AddRootTDL.xaml
    /// </summary>
    public partial class AddRootTDL : Window
    {
        TDLOperations tdl;
        public AddRootTDL(TDLOperations tdl)
        {
            InitializeComponent();
            this.tdl = tdl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var text = TextBox.Text;
            tdl.AddRootTdl(text);
            this.Close();
        }
    }
}
