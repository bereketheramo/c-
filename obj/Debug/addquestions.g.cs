﻿#pragma checksum "..\..\addquestions.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1A94DC03FBAD34E72BC73A937D61FF86A7614EC5"
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
using quizapp;


namespace quizapp {
    
    
    /// <summary>
    /// addquestions
    /// </summary>
    public partial class addquestions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnback;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQ;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtopa;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtopb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtopc;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtopd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtans;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\addquestions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnsubmit;
        
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
            System.Uri resourceLocater = new System.Uri("/quizapp;component/addquestions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addquestions.xaml"
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
            this.btnback = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\addquestions.xaml"
            this.btnback.Click += new System.Windows.RoutedEventHandler(this.Btnback_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtQ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtopa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtopb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtopc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtopd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtans = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnsubmit = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\addquestions.xaml"
            this.btnsubmit.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
