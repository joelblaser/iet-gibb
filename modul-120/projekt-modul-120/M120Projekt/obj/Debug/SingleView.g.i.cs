// Updated by XamlIntelliSenseFileGenerator 17.09.2020 13:21:20
#pragma checksum "..\..\SingleView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D47166C5CE6912D74EAF118436417549485851776B4FEB66E5971F8F9F64D282"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using M120Projekt;
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


namespace M120Projekt
{


    /// <summary>
    /// Register
    /// </summary>
    public partial class SingleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOperatorName;

#line default
#line hidden


#line 20 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRealName;

#line default
#line hidden


#line 22 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age;

#line default
#line hidden


#line 24 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpReleaseDate;

#line default
#line hidden


#line 26 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPosition;

#line default
#line hidden


#line 32 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnArmorPoints1;

#line default
#line hidden


#line 33 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnArmorPoints2;

#line default
#line hidden


#line 34 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnArmorPoints3;

#line default
#line hidden


#line 38 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnSpeedPoints1;

#line default
#line hidden


#line 39 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnSpeedPoints2;

#line default
#line hidden


#line 40 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnSpeedPoints3;

#line default
#line hidden


#line 44 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnIsDefaultOperator;

#line default
#line hidden


#line 45 "..\..\SingleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnIsNotDefaultOperator;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/M120Projekt;component/singleview.xaml", System.UriKind.Relative);

#line 1 "..\..\SingleView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 11 "..\..\SingleView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.New);

#line default
#line hidden
                    return;
                case 2:

#line 12 "..\..\SingleView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);

#line default
#line hidden
                    return;
                case 3:

#line 13 "..\..\SingleView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);

#line default
#line hidden
                    return;
                case 4:

#line 14 "..\..\SingleView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);

#line default
#line hidden
                    return;
                case 5:
                    this.txtOperatorName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.txtRealName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.age = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.dpReleaseDate = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 9:
                    this.cbPosition = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 10:
                    this.rbtnArmorPoints1 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 11:
                    this.rbtnArmorPoints2 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 12:
                    this.rbtnArmorPoints3 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 13:
                    this.rbtnSpeedPoints1 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 14:
                    this.rbtnSpeedPoints2 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 15:
                    this.rbtnSpeedPoints3 = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 16:
                    this.rbtnIsDefaultOperator = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 17:
                    this.rbtnIsNotDefaultOperator = ((System.Windows.Controls.RadioButton)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

