﻿#pragma checksum "..\..\..\..\..\Views\Pages\HomeSetting.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C01D815A0DE174E9437E80C5CD5CF34295128931"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using TCPLinker.Base.Converters;
using TCPLinker.Views.Pages;


namespace TCPLinker.Views.Pages {
    
    
    /// <summary>
    /// HomeSetting
    /// </summary>
    public partial class HomeSetting : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 160 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProgramDataGrid;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TCPLinker;component/views/pages/homesetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProgramDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 221 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
            this.MessageTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MessageTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 263 "..\..\..\..\..\Views\Pages\HomeSetting.xaml"
            this.LogTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LogTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

