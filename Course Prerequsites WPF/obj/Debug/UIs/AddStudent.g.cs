﻿#pragma checksum "..\..\..\UIs\AddStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A23926C4BA52E77D371D164BA86AE7F27FC9FD03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Course_Prerequsites_WPF.UIs;
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


namespace Course_Prerequsites_WPF.UIs {
    
    
    /// <summary>
    /// AddStudent
    /// </summary>
    public partial class AddStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudPassword;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudID;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StudYear;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FinishedCourses;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UIs\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/addstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\AddStudent.xaml"
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
            this.StudName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.StudPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StudID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 33 "..\..\..\UIs\AddStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StudYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 35 "..\..\..\UIs\AddStudent.xaml"
            ((System.Windows.Controls.Image)(target)).AddHandler(System.Windows.Input.Mouse.MouseUpEvent, new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseUp));
            
            #line default
            #line hidden
            return;
            case 7:
            this.FinishedCourses = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\UIs\AddStudent.xaml"
            this.FinishedCourses.Click += new System.Windows.RoutedEventHandler(this.FinishedCourses_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\..\UIs\AddStudent.xaml"
            this.CheckBox.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

