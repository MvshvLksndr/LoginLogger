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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Logger logger = new Logger();
            if (AuthService.isValid(tbLogin.Text, tbPass.Text) == true)
            {
                logger.isTrue(tbLogin.Text, tbPass.Text);
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
                logger.isFalse (tbLogin.Text, tbPass.Text);
            }
        }
    }
}
