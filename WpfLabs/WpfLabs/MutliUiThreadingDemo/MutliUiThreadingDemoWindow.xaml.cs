﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfLabs.MutliUiThreadingDemo
{
    /// <summary>
    /// MutliUiThreadingDemoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MutliUiThreadingDemoWindow : Window
    {
        public MutliUiThreadingDemoWindow()
        {
            InitializeComponent();
        }

        private void RunNewWindow_OnClick(object sender, RoutedEventArgs e)
        {
            RunWindowHelper.RunNewWindowAsync<OtherUiThreadingWindow>();
        }
    }
}
