﻿#pragma checksum "..\..\..\AktifBebek.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232ED05CEABFAB45936C89038A5080E3919EFDC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
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
using XMLOkuyucu;


namespace XMLOkuyucu {
    
    
    /// <summary>
    /// AktifBebek
    /// </summary>
    public partial class AktifBebek : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UrunDataGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ToplamUrunSayisi;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonYolla;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Kategoriler;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OzelliklerGrid;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BigtarzAnaKategoriKarsiligi;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BigtarzKategoriKarsiligi;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\AktifBebek.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BigtarzAltKategoriKarsiligi;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XMLOkuyucu;V1.0.0.0;component/aktifbebek.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AktifBebek.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UrunDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\AktifBebek.xaml"
            this.UrunDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnUrunSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\AktifBebek.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnOkuClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ToplamUrunSayisi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.buttonYolla = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\AktifBebek.xaml"
            this.buttonYolla.Click += new System.Windows.RoutedEventHandler(this.OnYollaClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Kategoriler = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.OzelliklerGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.BigtarzAnaKategoriKarsiligi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BigtarzKategoriKarsiligi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BigtarzAltKategoriKarsiligi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 47 "..\..\..\AktifBebek.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAnaKategoriKarsiligiEkleAsync);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

