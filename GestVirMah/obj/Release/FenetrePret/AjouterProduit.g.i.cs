﻿#pragma checksum "..\..\..\FenetrePret\AjouterProduit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DC46F40BC5693DA46016E92661D46AEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestVirMah;
using MahApps.Metro.Controls;
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


namespace GestVirMah.FenetrePret {
    
    
    /// <summary>
    /// AjouterProduit
    /// </summary>
    public partial class AjouterProduit : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Prod;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Valider_;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboFournis;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomProd;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RefProd;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrixHt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\FenetrePret\AjouterProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrixTTC;
        
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
            System.Uri resourceLocater = new System.Uri("/GestVirMah;component/fenetrepret/ajouterproduit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FenetrePret\AjouterProduit.xaml"
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
            this.Prod = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Valider_ = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\FenetrePret\AjouterProduit.xaml"
            this.Valider_.Click += new System.Windows.RoutedEventHandler(this.Valider__Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\..\FenetrePret\AjouterProduit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboFournis = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.NomProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.RefProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PrixHt = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\FenetrePret\AjouterProduit.xaml"
            this.PrixHt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PrixHt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PrixTTC = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\FenetrePret\AjouterProduit.xaml"
            this.PrixTTC.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PrixTTC_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

