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

namespace RealEstateBrowser
{
    /// <summary>
    /// Interaction logic for Home2.xaml
    /// </summary>
    public partial class Home2 : Window
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome1 welcome1 = new Welcome1();
            App.Current.MainWindow = welcome1;
            this.Close();
            welcome1.Show();
        }

        private void Location_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            SearchBar.Text = "";
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            SearchBar.Text = "Enter a location ...";
        }
    }
}
