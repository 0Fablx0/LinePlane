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

namespace LinePlane
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        AplicationContext DB;

        public EnterWindow()
        {
            InitializeComponent();

            DB = new AplicationContext();
        }

        private void EnterButtonClic(object sender, RoutedEventArgs e)
        {
            string Login = LoginField.Text.ToLower().Trim();
            string password = PasswordField.Password.Trim();

            //if ()

        }
    }
}
