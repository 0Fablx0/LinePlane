﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B86AE8CC70DC008BC886B56817F9941C8D4A7A1F"
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
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Display_Area;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border User_Border;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Tool_grid;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ToolBAr_Border;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mainroom;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bedroom;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border kitchen;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border appliances;
        
        #line default
        #line hidden
        
        
        #line 280 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border wardrobe;
        
        #line default
        #line hidden
        
        
        #line 317 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bathroom;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border interior;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((LinePlaneCore.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Display_Area = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Abort_Paint);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 42 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_button);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 56 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Next);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 59 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Save);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 64 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_NigthDay);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 70 "..\..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.User_Button);
            
            #line default
            #line hidden
            return;
            case 9:
            this.User_Border = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            
            #line 80 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_enter_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 85 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_registration_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Tool_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.ToolBAr_Border = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            
            #line 99 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cursor);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 103 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Hand);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 107 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Edit);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 113 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Mainroom);
            
            #line default
            #line hidden
            return;
            case 18:
            this.mainroom = ((System.Windows.Controls.Border)(target));
            return;
            case 19:
            
            #line 162 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Bedroom);
            
            #line default
            #line hidden
            return;
            case 20:
            this.bedroom = ((System.Windows.Controls.Border)(target));
            return;
            case 21:
            
            #line 194 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Kitchen);
            
            #line default
            #line hidden
            return;
            case 22:
            this.kitchen = ((System.Windows.Controls.Border)(target));
            return;
            case 23:
            
            #line 234 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Appliances);
            
            #line default
            #line hidden
            return;
            case 24:
            this.appliances = ((System.Windows.Controls.Border)(target));
            return;
            case 25:
            
            #line 271 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Wardrobe);
            
            #line default
            #line hidden
            return;
            case 26:
            this.wardrobe = ((System.Windows.Controls.Border)(target));
            return;
            case 27:
            
            #line 313 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Bathroom);
            
            #line default
            #line hidden
            return;
            case 28:
            this.bathroom = ((System.Windows.Controls.Border)(target));
            return;
            case 29:
            
            #line 350 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Interior);
            
            #line default
            #line hidden
            return;
            case 30:
            this.interior = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

