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
    public partial class Welcome2 : UserControl
    {
        public Welcome2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Welcome1());
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Welcome3());
        }
    }
}
