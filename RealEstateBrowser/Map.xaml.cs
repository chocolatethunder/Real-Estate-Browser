using System;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Design;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Diagnostics;

namespace RealEstateBrowser
{
    public partial class SwitchMapViews : UserControl
    {
        LocationConverter locConverter = new LocationConverter();

        public SwitchMapViews()
        {
            InitializeComponent();
            //Set focus on the map
            myMap.Focus();
            // Displays the current latitude and longitude as the map animates.
            myMap.ViewChangeOnFrame += new EventHandler<MapEventArgs>(viewMap_ViewChangeOnFrame);
            // The default animation level: navigate between different map locations.
            //viewMap.AnimationLevel = AnimationLevel.Full;
        }

        private void viewMap_ViewChangeOnFrame(object sender, MapEventArgs e)
        {
            // Gets the map object that raised this event.
            Map map = sender as Map;
            // Determine if we have a valid map object.
            if (map != null)
            {
                // Gets the center of the current map view for this particular frame.
                Location mapCenter = map.Center;

                // Updates the latitude and longitude values, in real time,
                // as the map animates to the new location.
                //txtLatitude.Text = string.Format(CultureInfo.InvariantCulture,
                //  "{0:F5}", mapCenter.Latitude);
                //txtLongitude.Text = string.Format(CultureInfo.InvariantCulture,
                //    "{0:F5}", mapCenter.Longitude);
            }
        }

        private void ChangeMapView_Click(object sender, RoutedEventArgs e)
        {
            // Parse the information of the button's Tag property
            string[] tagInfo = ((Button)sender).Tag.ToString().Split(' ');
            Location center = (Location)locConverter.ConvertFrom(tagInfo[0]);
            double zoom = System.Convert.ToDouble(tagInfo[1]);

            // Set the map view
            myMap.SetView(center, zoom);

        }

        private void AnimationLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)(((ComboBox)sender).SelectedItem);
            string v = cbi.Content as string;
            if (!string.IsNullOrEmpty(v) && myMap != null)
            {
                AnimationLevel newLevel = (AnimationLevel)Enum.Parse(typeof(AnimationLevel), v, true);
                myMap.AnimationLevel = newLevel;
            }
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Home2());
        }

        private void Show_Bed_Popup(object sender, RoutedEventArgs e)
        {
            BedPopup.IsOpen = true;
        }

        private void Hide_Bath_Popup(object sender, RoutedEventArgs e)
        {
            BathPopup.IsOpen = false;
        }

        private void Show_Bath_Popup(object sender, RoutedEventArgs e)
        {
            BathPopup.IsOpen = true;
        }

        private void Hide_Bed_Popup(object sender, RoutedEventArgs e)
        {
            BedPopup.IsOpen = false;
        }

        private void Show_PropertyType_Popup(object sender, RoutedEventArgs e)
        {
            PropertyTypePopup.IsOpen = true;
        }

        private void Hide_PropertyType_Popup(object sender, RoutedEventArgs e)
        {
            PropertyTypePopup.IsOpen = false;
        }

        private void Show_Favourites(object sender, RoutedEventArgs e)
        {
            // Instantiate window
            FavouritesModal favouritesModal = new FavouritesModal();
            // Center it:
            favouritesModal.Top = (System.Windows.SystemParameters.PrimaryScreenHeight - favouritesModal.Height) / 2;
            favouritesModal.Left = (System.Windows.SystemParameters.PrimaryScreenWidth - favouritesModal.Width) / 2;
            // Show window modally  NOTE: Returns only when window is closed
            Nullable<bool> dialogResult = favouritesModal.ShowDialog();
        }

        private void Show_Compare(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CompareModal());
            //CompareModal compareModal = new CompareModal();
            // Center it:
            //compareModal.Top = (System.Windows.SystemParameters.PrimaryScreenHeight - compareModal.Height) / 2;
            //compareModal.Left = (System.Windows.SystemParameters.PrimaryScreenWidth - compareModal.Width) / 2;
            // Show window modally  NOTE: Returns only when window is closed
            //Nullable<bool> dialogResult = compareModal.ShowDialog();
        }

        private void Pin_Click(object sender, RoutedEventArgs e)
        {
            PropertyModal propertyModal = new PropertyModal();
            propertyModal.Top = (System.Windows.SystemParameters.PrimaryScreenHeight - propertyModal.Height) / 2;
            propertyModal.Left = (System.Windows.SystemParameters.PrimaryScreenWidth - propertyModal.Width) / 2;
            propertyModal.Topmost = true;
            Nullable<bool> dialogResult = propertyModal.ShowDialog();
            e.Handled = true;
        }

        private void Show_Pin_Popup(object sender, RoutedEventArgs e)
        {
            PinPopup.IsOpen = true;
        }

        private void Hide_Pin_Popup(object sender, RoutedEventArgs e)
        {
            PinPopup.IsOpen = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}