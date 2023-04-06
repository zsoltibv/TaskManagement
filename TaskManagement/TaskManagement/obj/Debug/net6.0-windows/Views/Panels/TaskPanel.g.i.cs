﻿#pragma checksum "..\..\..\..\..\Views\Panels\TaskPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C5616D8C6A37E80C81B7C9C3A8A9EF7D8A3C9A2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TaskManagement.ViewModels;


namespace TaskManagement.Views.Panels {
    
    
    /// <summary>
    /// TaskPanel
    /// </summary>
    public partial class TaskPanel : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Views\Panels\TaskPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Container;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Panels\TaskPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListContainer;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Views\Panels\TaskPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView taskListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TaskManagement;component/views/panels/taskpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Panels\TaskPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Container = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ListContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.taskListView = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\..\..\..\Views\Panels\TaskPanel.xaml"
            this.taskListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnTaskClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

