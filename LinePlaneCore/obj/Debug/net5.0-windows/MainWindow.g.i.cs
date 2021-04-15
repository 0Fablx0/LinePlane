﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92C09E5167E6FA55E32CC6019BD17208785C0F59"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LinePlaneCore;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LinePlaneCore {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Display_Area;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border User_Border;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Tool_grid;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTB;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ToolBAr_Border;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LinePlaneCore;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\MainWindow.xaml"
            ((LinePlaneCore.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Display_Area = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.canvas.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.canvas.PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Abort_Paint);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_button);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 55 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Next);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 58 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Save);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_NigthDay);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 69 "..\..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.User_Button);
            
            #line default
            #line hidden
            return;
            case 9:
            this.User_Border = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            
            #line 84 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_enter_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 89 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_registration_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Tool_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.ButtonTB = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\MainWindow.xaml"
            this.ButtonTB.Click += new System.Windows.RoutedEventHandler(this.ToolBar_Button);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ToolBAr_Border = ((System.Windows.Controls.Border)(target));
            return;
            case 15:
            
            #line 105 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Hand);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 109 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Edit);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 113 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cursor);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 117 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cursor);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
