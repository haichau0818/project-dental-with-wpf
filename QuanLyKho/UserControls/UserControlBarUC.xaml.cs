﻿using QuanLyKho.ViewModel;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyKho.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlBarUC.xaml
    /// </summary>
    public partial class UserControlBarUC : UserControl
    {
        public ControlBarVM ViewModel { get; set; }
        public UserControlBarUC()
        {
            InitializeComponent();
            this.DataContext = ViewModel=new ControlBarVM();
        }
    }
}
