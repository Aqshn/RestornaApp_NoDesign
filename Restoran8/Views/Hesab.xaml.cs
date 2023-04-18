﻿using Restoran8.ViewModels;
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
using System.Windows.Shapes;

namespace Restoran8.Views
{
    /// <summary>
    /// Interaction logic for Hesab.xaml
    /// </summary>
    public partial class Hesab : Window
    {
        public BTn1 bTn1;
        public BTn2 bTn2;
        public BTn3 bTn3;
        public BTn4 bTn4;
        public BTn5 bTn5;
        public BTn6 bTn6;
        public void B1(BTn1 button)
        {
            bTn1 = button;
            txt2.Text = BTn1.GetInstance().garson.ToString();
            txt4.Text = BTn1.GetInstance().hesab.ToString();
        }
        public void B2(BTn2 button)
        {
            bTn2 = button;
            txt2.Text = BTn2.GetInstance().garson.ToString();
            txt4.Text = BTn2.GetInstance().hesab.ToString();
        }
        public void B3(BTn3 button)
        {
            bTn3 = button;
            txt2.Text = BTn3.GetInstance().garson.ToString();
            txt4.Text = BTn3.GetInstance().hesab.ToString();
        }
        public void B4(BTn4 button)
        {
            bTn4 = button;
            txt2.Text = BTn4.GetInstance().garson.ToString();
            txt4.Text = BTn4.GetInstance().hesab.ToString();
        }
        public void B5(BTn5 button)
        {
            bTn5 = button;
            txt2.Text = BTn5.GetInstance().garson.ToString();
            txt4.Text = BTn5.GetInstance().hesab.ToString();
        }
        public void B6(BTn6 button)
        {
            bTn6 = button;
            txt2.Text = BTn6.GetInstance().garson.ToString();
            txt4.Text = BTn6.GetInstance().hesab.ToString();
        }
        public Hesab()
        {
            InitializeComponent();
        }
        public void HesabClick(object sender, RoutedEventArgs e)
        {
            if (bTn1 != null)
            {
                BTn1.GetInstance().Clear();
            }
            else if (bTn2 != null)
            {
                BTn2.GetInstance().Clear();
            }
            else if (bTn3 != null)
            {
                BTn3.GetInstance().Clear();
            }
            else if (bTn4 != null)
            {
                BTn4.GetInstance().Clear();
            }
            else if (bTn5 != null)
            {
                BTn5.GetInstance().Clear();
            }
            else if (bTn6 != null)
            {
                BTn6.GetInstance().Clear();
            }
            MessageBox.Show("5 ulduz qoymaqi unutmuyun!");
            MessageBox.Show("Aqsine de 12 qoyarsan");
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
