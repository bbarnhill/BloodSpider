﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GlucaTrackWPF.ViewModels;

namespace GlucaTrackWPF.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginViewModel ViewModel
        {
            get
            {
                return DataContext as LoginViewModel;
            }
        }

        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Login.Password = txtPassword.SecurePassword;
            if (ViewModel is LoginViewModel && ViewModel.PerformLogin())
                Content = new MainView(ViewModel);
        }
    }
}
