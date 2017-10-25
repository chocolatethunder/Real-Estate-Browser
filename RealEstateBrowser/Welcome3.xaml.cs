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
    /// Interaction logic for Welcome3.xaml
    /// </summary>
    public partial class Welcome3 : Window
    {
        public Welcome3()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Welcome2 welcome2 = new Welcome2();
            App.Current.MainWindow = welcome2;
            welcome2.WindowState = WindowState.Maximized;
            welcome2.Show();
            this.Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            SwitchMapViews map = new SwitchMapViews();
            App.Current.MainWindow = map;
            map.WindowState = WindowState.Maximized;
            map.Show();
            this.Close();
        }
    }
}
