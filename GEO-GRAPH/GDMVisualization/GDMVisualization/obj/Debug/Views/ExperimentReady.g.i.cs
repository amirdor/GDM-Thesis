﻿#pragma checksum "C:\Users\Ofra\Documents\Visual Studio 2010\Projects\GDMVisualization\GDMVisualization\Views\ExperimentReady.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35D7B40B782772C56BFAA3C973DEC2A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GDMVisualization.Views {
    
    
    public partial class ExperimentReady : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas canvas1;
        
        internal System.Windows.Controls.Grid grid;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.Primitives.ToggleButton btnRunTutorial;
        
        internal System.Windows.Controls.Primitives.ToggleButton btnRunExperiment;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GDMVisualization;component/Views/ExperimentReady.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.canvas1 = ((System.Windows.Controls.Canvas)(this.FindName("canvas1")));
            this.grid = ((System.Windows.Controls.Grid)(this.FindName("grid")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.btnRunTutorial = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("btnRunTutorial")));
            this.btnRunExperiment = ((System.Windows.Controls.Primitives.ToggleButton)(this.FindName("btnRunExperiment")));
        }
    }
}

