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
    /// Interaction logic for PropertyModal.xaml
    /// </summary>
    public partial class PropertyModal : Window
    {
        private double height;
        private double width;

        public PropertyModal()
        {
            InitializeComponent();
            // Instantiate modal window with dimensions = 90% of system resolution:
            height = System.Windows.SystemParameters.PrimaryScreenHeight * 0.9;
            width = System.Windows.SystemParameters.PrimaryScreenWidth * 0.9;
            this.Height = height;
            this.Width = width;
        }
        private void AddToFavourites(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
