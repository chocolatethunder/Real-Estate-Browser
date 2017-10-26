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
    /// Interaction logic for RealEstateBrowser.xaml
    /// </summary>
    public partial class REB : Window
    {
        public REB()
        {
            InitializeComponent();
            App.Current.MainWindow.WindowState = WindowState.Maximized;
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Home());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
    }
}
