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

namespace RealEstateBrowser
{
    /// <summary>
    /// Interaction logic for Welcome2.xaml
    /// </summary>
    public partial class Welcome2 : Window
    {
        public Welcome2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Welcome1 welcome1 = new Welcome1();
            App.Current.MainWindow = welcome1;
            welcome1.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Welcome1 welcome1 = new Welcome1();
            App.Current.MainWindow = welcome1;
            welcome1.WindowState = WindowState.Maximized;
            welcome1.Show();
            this.Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Welcome3 welcome3 = new Welcome3();
            App.Current.MainWindow = welcome3;
            welcome3.WindowState = WindowState.Maximized;
            welcome3.Show();
            this.Close();
        }
    }
}
