﻿#pragma checksum "..\..\HistoryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0042556A21C01AACA312D8520247319A695DCF3BCBD7E80E44B1D0B0AA5F800B"
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
    /// HistoryPage
    /// </summary>
    public partial class HistoryPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\HistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFilter;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\HistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DateSort;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\HistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridHistory;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\HistoryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/DEMLASTMAY;component/historypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HistoryPage.xaml"
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
            
            #line 9 "..\..\HistoryPage.xaml"
            ((DEMLASTMAY.HistoryPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\HistoryPage.xaml"
            this.ComboFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DateSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\HistoryPage.xaml"
            this.DateSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DateSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.BtnBackHistory = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\HistoryPage.xaml"
            this.BtnBackHistory.Click += new System.Windows.RoutedEventHandler(this.BtnBackHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

