﻿#pragma checksum "..\..\..\..\Views\AdminPage\PageAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "323F59E77E6D07C8D8218C3D714D86FBA22A701E672FC022A0AC54292695FDCC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using authorization.Views.AdminPage;


namespace authorization.Views.AdminPage {
    
    
    /// <summary>
    /// PageAdmin
    /// </summary>
    public partial class PageAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameEditPage;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGoBack;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEdit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxSearch;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridTablica;
        
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
            System.Uri resourceLocater = new System.Uri("/authorization;component/views/adminpage/pageadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
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
            
            #line 7 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            ((authorization.Views.AdminPage.PageAdmin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FrameEditPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.ButtonGoBack = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.ButtonGoBack.Click += new System.Windows.RoutedEventHandler(this.ButtonGoBack_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonEdit = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.ButtonEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 47 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textboxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.textboxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textboxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DataGridTablica = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\..\..\Views\AdminPage\PageAdmin.xaml"
            this.DataGridTablica.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.DataGridTablica_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
