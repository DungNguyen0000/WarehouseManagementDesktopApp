﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34C6F2FA22D6B34F5F695FAF399A7FA22BE710F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WarehouseManagementDesktopApp;
using WarehouseManagementDesktopApp.Behaviors;
using WarehouseManagementDesktopApp.Core.ValueConverter.MyApp.Tools;
using WarehouseManagementDesktopApp.Core.ViewModels;
using WarehouseManagementDesktopApp.Resources.Components;
using WarehouseManagementDesktopApp.Resources.Components.Message;
using WarehouseManagementDesktopApp.Views.GoodExport;
using WarehouseManagementDesktopApp.Views.GoodLocations;
using WarehouseManagementDesktopApp.Views.GoodReceipts;
using WarehouseManagementDesktopApp.Views.History;
using WarehouseManagementDesktopApp.Views.Login;
using WarehouseManagementDesktopApp.Views.Report;


namespace WarehouseManagementDesktopApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.MainWindow Main_Window;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost DialogBox;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Heading_panel;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img1;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Loginbtn;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Settingbtn;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Supervisorbtn;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Reporttn;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Alertbtn;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Historybtn;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WarehouseManagementDesktopApp.Resources.Components.MenuButton Helpbtn;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox panel_Menu;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ViewPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WarehouseManagementDesktopApp;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Main_Window = ((WarehouseManagementDesktopApp.MainWindow)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.Main_Window.Closed += new System.EventHandler(this.Main_Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DialogBox = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 3:
            this.Heading_panel = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.img1 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.Loginbtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 6:
            this.Settingbtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 7:
            this.Supervisorbtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 8:
            this.Reporttn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 9:
            this.Alertbtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 10:
            this.Historybtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 11:
            this.Helpbtn = ((WarehouseManagementDesktopApp.Resources.Components.MenuButton)(target));
            return;
            case 12:
            this.panel_Menu = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 13:
            this.ViewPanel = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

