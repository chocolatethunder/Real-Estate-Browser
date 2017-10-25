﻿#pragma checksum "..\..\Map.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "182D5C16CE4B7C1FB8F5C24106418365"
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
    public partial class SwitchMapViews : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map myMap;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNorthAmerica;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewYork;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSanFrancisco;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVancouver;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLatitude;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Map.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLongitude;
        
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
            this.btnNorthAmerica = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Map.xaml"
            this.btnNorthAmerica.Click += new System.Windows.RoutedEventHandler(this.ChangeMapView_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNewYork = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Map.xaml"
            this.btnNewYork.Click += new System.Windows.RoutedEventHandler(this.ChangeMapView_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSanFrancisco = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Map.xaml"
            this.btnSanFrancisco.Click += new System.Windows.RoutedEventHandler(this.ChangeMapView_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnVancouver = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Map.xaml"
            this.btnVancouver.Click += new System.Windows.RoutedEventHandler(this.ChangeMapView_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 30 "..\..\Map.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AnimationLevel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtLatitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtLongitude = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

