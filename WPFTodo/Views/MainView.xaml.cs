﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTodo.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            InitializeComponent();
            this.btnMin.Click += (s, e) => this.WindowState = WindowState.Minimized;
            this.btnMax.Click += (s, e) => ShowWindowState();
            this.btnClose.Click += (s, e) => this.Close();

            ColorZone.MouseMove += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };

            ColorZone.MouseDoubleClick += (s, e) => ShowWindowState();

            menuBar.SelectionChanged += (s, e)=>{
                drawerHost.IsLeftDrawerOpen = false;
            };
        }

        void ShowWindowState()
        {
            if (WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

    }
}
