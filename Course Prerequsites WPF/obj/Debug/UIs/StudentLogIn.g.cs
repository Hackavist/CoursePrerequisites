﻿#pragma checksum "..\..\..\UIs\StudentLogIn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12BDD1FE2386FF7CC3EEA10DDC94076E"
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
    /// StudentLogIn
    /// </summary>
    public partial class StudentLogIn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VisiblePass_txt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password_txt;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UIs\StudentLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image EyeImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/studentlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\StudentLogIn.xaml"
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
            this.BackBTN = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UIs\StudentLogIn.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VisiblePass_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\UIs\StudentLogIn.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.loginButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Password_txt = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 42 "..\..\..\UIs\StudentLogIn.xaml"
            this.Password_txt.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_txt_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EyeImage = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\..\UIs\StudentLogIn.xaml"
            this.EyeImage.MouseLeave += new System.Windows.Input.MouseEventHandler(this.EyeImage_MouseLeave);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\UIs\StudentLogIn.xaml"
            this.EyeImage.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EyeImage_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\UIs\StudentLogIn.xaml"
            this.EyeImage.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.EyeImage_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

