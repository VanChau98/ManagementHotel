﻿#pragma checksum "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2D7F4EBD9A154C72750E8BD72A939FD169EAAFE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagementHotel.UserControlXAML.ReceptionistUC;
using ManagementHotel.UserControlXAML.ReceptionistUC.BookingUC;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ManagementHotel.UserControlXAML.ReceptionistUC {
    
    
    /// <summary>
    /// Booking
    /// </summary>
    public partial class Booking : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView BookingMenu;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ManagementHotel.UserControlXAML.ReceptionistUC.BookingUC.AddCustomer addCustomer;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ManagementHotel.UserControlXAML.ReceptionistUC.BookingUC.AddService addService;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagementHotel;component/usercontrolxaml/receptionistuc/booking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.BookingMenu = ((System.Windows.Controls.ListView)(target));
            
            #line 19 "..\..\..\..\UserControlXAML\ReceptionistUC\Booking.xaml"
            this.BookingMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookingMenu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addCustomer = ((ManagementHotel.UserControlXAML.ReceptionistUC.BookingUC.AddCustomer)(target));
            return;
            case 3:
            this.addService = ((ManagementHotel.UserControlXAML.ReceptionistUC.BookingUC.AddService)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
