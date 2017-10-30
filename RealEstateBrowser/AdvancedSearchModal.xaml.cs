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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AdvancedSearchModal : Window
    {
        public AdvancedSearchModal()
        {
            InitializeComponent();
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight * 0.9;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth * 0.9;
        }

        private void Refine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
