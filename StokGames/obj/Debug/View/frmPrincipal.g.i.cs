﻿#pragma checksum "..\..\..\View\frmPrincipal.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0D37E7DC26F4F440E5150CF69B72AD14C6A2DD10"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using StokGames.View;
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


namespace StokGames.View {
    
    
    /// <summary>
    /// frmPrincipal
    /// </summary>
    public partial class frmPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal StokGames.View.frmPrincipal frmPrincipalAdministracao;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniMenu;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniCadastro;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniFuncionario;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniCliente;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniProduto;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniFornecedor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mniSair;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMensagemEntrada;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\frmPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogo;
        
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
            System.Uri resourceLocater = new System.Uri("/StokGames;component/view/frmprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmPrincipal.xaml"
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
            this.frmPrincipalAdministracao = ((StokGames.View.frmPrincipal)(target));
            return;
            case 2:
            this.mniMenu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.mniCadastro = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.mniFuncionario = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\View\frmPrincipal.xaml"
            this.mniFuncionario.Click += new System.Windows.RoutedEventHandler(this.MniFuncionario_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mniCliente = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\View\frmPrincipal.xaml"
            this.mniCliente.Click += new System.Windows.RoutedEventHandler(this.MniCliente_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mniProduto = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\View\frmPrincipal.xaml"
            this.mniProduto.Click += new System.Windows.RoutedEventHandler(this.MniProduto_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mniFornecedor = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\View\frmPrincipal.xaml"
            this.mniFornecedor.Click += new System.Windows.RoutedEventHandler(this.MniFornecedor_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mniSair = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\View\frmPrincipal.xaml"
            this.mniSair.Click += new System.Windows.RoutedEventHandler(this.MniSair_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblMensagemEntrada = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.imgLogo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

