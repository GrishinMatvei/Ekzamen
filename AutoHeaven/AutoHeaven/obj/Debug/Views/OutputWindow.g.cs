﻿#pragma checksum "..\..\..\Views\OutputWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5DDBCF9E09A9B5F4026817CF514E7A0EA182C4E83A8130B21695152757F8434C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoHeaven.Views;
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


namespace AutoHeaven.Views {
    
    
    /// <summary>
    /// OutputWindow
    /// </summary>
    public partial class OutputWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\OutputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchField;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\OutputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filterSelector;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\OutputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterEnable;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\OutputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterDisable;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\OutputWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ordersDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoHeaven;component/views/outputwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\OutputWindow.xaml"
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
            this.searchField = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Views\OutputWindow.xaml"
            this.searchField.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.searchField_TextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.filterSelector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.filterEnable = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\OutputWindow.xaml"
            this.filterEnable.Click += new System.Windows.RoutedEventHandler(this.filterEnable_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.filterDisable = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\OutputWindow.xaml"
            this.filterDisable.Click += new System.Windows.RoutedEventHandler(this.filterDisable_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ordersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\Views\OutputWindow.xaml"
            this.ordersDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ordersDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

