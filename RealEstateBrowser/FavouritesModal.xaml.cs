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
    /// Interaction logic for FavouritesModal.xaml
    /// </summary>
    public partial class FavouritesModal : Window
    {
        public FavouritesModal()
        {
            InitializeComponent();
            // Instantiate modal window with dimensions = 90% of system resolution:
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight * 0.9;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth * 0.9;
        }

        private void Show_Property(object sender, MouseButtonEventArgs e)
        {
            PropertyModal propertyModal = new PropertyModal();
            propertyModal.Top = (System.Windows.SystemParameters.PrimaryScreenHeight - propertyModal.Height) / 2;
            propertyModal.Left = (System.Windows.SystemParameters.PrimaryScreenWidth - propertyModal.Width) / 2;
            Nullable<bool> dialogResult = propertyModal.ShowDialog();
        }
    }
}
