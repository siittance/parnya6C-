﻿#pragma checksum "..\..\..\..\View\Pages\Stranica30Day.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2333A812ABBB0684D16E8A2F4D04BD489692B3FFC399C45D458F6B12EFCA9ADC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CalendarEmocia1.View.Pages;
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


namespace CalendarEmocia1.View.Pages {
    
    
    /// <summary>
    /// Stranica30Day
    /// </summary>
    public partial class Stranica30Day : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 80 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DataListbox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel DayPanel;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock daytext;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MonthYearTextBlock;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ball;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\View\Pages\Stranica30Day.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame VyborKakoiTiSegodnya;
        
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
            System.Uri resourceLocater = new System.Uri("/CalendarEmocia1;component/view/pages/stranica30day.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\Stranica30Day.xaml"
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
            
            #line 49 "..\..\..\..\View\Pages\Stranica30Day.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 52 "..\..\..\..\View\Pages\Stranica30Day.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataListbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.DayPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            this.daytext = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.MonthYearTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ball = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 8:
            this.VyborKakoiTiSegodnya = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

