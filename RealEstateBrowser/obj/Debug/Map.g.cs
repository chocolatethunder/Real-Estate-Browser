﻿#pragma checksum "..\..\Map.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D1284EDB82A48FFD71B6B7EF6F6F0A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Maps.MapControl.WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RealEstateBrowser {
    
    
    /// <summary>
    /// SwitchMapViews
    /// </summary>
    public partial class SwitchMapViews : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map myMap;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pin1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pin2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pin3;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BedButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BathButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PropertyTypeButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup BedPopup;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup BathPopup;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PropertyTypePopup;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PinPopup;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RealEstateBrowser;component/map.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Map.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.myMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 3:
            this.Pin1 = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Map.xaml"
            this.Pin1.Click += new System.Windows.RoutedEventHandler(this.Pin_Click);
            
            #line default
            #line hidden
            
            #line 12 "..\..\Map.xaml"
            this.Pin1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Show_Pin_Popup);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pin2 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Map.xaml"
            this.Pin2.Click += new System.Windows.RoutedEventHandler(this.Pin_Click);
            
            #line default
            #line hidden
            
            #line 20 "..\..\Map.xaml"
            this.Pin2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Show_Pin_Popup);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pin3 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Map.xaml"
            this.Pin3.Click += new System.Windows.RoutedEventHandler(this.Pin_Click);
            
            #line default
            #line hidden
            
            #line 28 "..\..\Map.xaml"
            this.Pin3.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Show_Pin_Popup);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 38 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BedButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Map.xaml"
            this.BedButton.Click += new System.Windows.RoutedEventHandler(this.Show_Bed_Popup);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BathButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Map.xaml"
            this.BathButton.Click += new System.Windows.RoutedEventHandler(this.Show_Bath_Popup);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PropertyTypeButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Map.xaml"
            this.PropertyTypeButton.Click += new System.Windows.RoutedEventHandler(this.Show_PropertyType_Popup);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Favourites);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 66 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_Compare);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BedPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 80 "..\..\Map.xaml"
            this.BedPopup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Hide_Bed_Popup);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 85 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 93 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 100 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hide_Bed_Popup);
            
            #line default
            #line hidden
            return;
            case 16:
            this.BathPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 107 "..\..\Map.xaml"
            this.BathPopup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Hide_Bath_Popup);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 112 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 120 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 127 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hide_Bath_Popup);
            
            #line default
            #line hidden
            return;
            case 20:
            this.PropertyTypePopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 134 "..\..\Map.xaml"
            this.PropertyTypePopup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Hide_PropertyType_Popup);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 139 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 144 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hide_PropertyType_Popup);
            
            #line default
            #line hidden
            return;
            case 23:
            this.PinPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 152 "..\..\Map.xaml"
            this.PinPopup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Hide_Pin_Popup);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 160 "..\..\Map.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hide_Pin_Popup);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

