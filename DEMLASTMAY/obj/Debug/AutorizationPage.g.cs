﻿#pragma checksum "..\..\AutorizationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13B7452906AB1680348EB1C8DEA2F519467C11DCF7F494C1D84411A87D7525FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DEMLASTMAY;
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


namespace DEMLASTMAY {
    
    
    /// <summary>
    /// AutorizationPage
    /// </summary>
    public partial class AutorizationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AutorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AutorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVisiblePasswordbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AutorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AutorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextShowHide;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AutorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/DEMLASTMAY;component/autorizationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AutorizationPage.xaml"
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
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtVisiblePasswordbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 37 "..\..\AutorizationPage.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPasswordbox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextShowHide = ((System.Windows.Controls.TextBlock)(target));
            
            #line 47 "..\..\AutorizationPage.xaml"
            this.TextShowHide.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ImgShowHide_MouseLeave);
            
            #line default
            #line hidden
            
            #line 48 "..\..\AutorizationPage.xaml"
            this.TextShowHide.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgShowHide_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 49 "..\..\AutorizationPage.xaml"
            this.TextShowHide.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ImgShowHide_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\AutorizationPage.xaml"
            this.BtnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
