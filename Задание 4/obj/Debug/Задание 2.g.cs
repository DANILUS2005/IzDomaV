#pragma checksum "..\..\Задание 2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47749D48A97008E36FA3C15BA9CF55DA055DC5912E24BA3188AD1DFB2AA0BCA5"
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
using Задание_4;


namespace Задание_4 {
    
    
    /// <summary>
    /// Задание_2
    /// </summary>
    public partial class Задание_2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Задание 2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox factorial;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Задание 2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Введите_число_клиентов_N;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Задание 2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button countFactorial;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Задание 2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label answerFactorial;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Задание 2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button perehod2;
        
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
            System.Uri resourceLocater = new System.Uri("/Задание 4;component/%d0%97%d0%b0%d0%b4%d0%b0%d0%bd%d0%b8%d0%b5%202.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Задание 2.xaml"
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
            this.factorial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Введите_число_клиентов_N = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.countFactorial = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Задание 2.xaml"
            this.countFactorial.Click += new System.Windows.RoutedEventHandler(this.countFactorial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.answerFactorial = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.perehod2 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Задание 2.xaml"
            this.perehod2.Click += new System.Windows.RoutedEventHandler(this.perehod2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

