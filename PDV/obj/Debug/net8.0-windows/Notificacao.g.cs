﻿#pragma checksum "..\..\..\Notificacao.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08F28AC8D6E2A98D4FD1FF325677A120B87EF756"
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
using PDV;
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


namespace PDV {
    
    
    /// <summary>
    /// Notificacao
    /// </summary>
    public partial class Notificacao : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tituloNotificacao;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image iconeNotificacao;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNotificacao;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFechar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSim;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Notificacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNao;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PDV;component/notificacao.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Notificacao.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tituloNotificacao = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.iconeNotificacao = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.txtNotificacao = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Notificacao.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnFechar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Notificacao.xaml"
            this.btnFechar.Click += new System.Windows.RoutedEventHandler(this.btnFechar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSim = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Notificacao.xaml"
            this.btnSim.Click += new System.Windows.RoutedEventHandler(this.btnSim_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnNao = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Notificacao.xaml"
            this.btnNao.Click += new System.Windows.RoutedEventHandler(this.btnNao_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
