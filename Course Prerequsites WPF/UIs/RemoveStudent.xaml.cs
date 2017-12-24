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
using Course_Prerequsites_WPF.Classes;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for RemoveStudent.xaml
    /// </summary>
    public partial class RemoveStudent : Window
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var x in WelcomePage.AllStudentsDictionary)
                comboBox.Items.Add(x.Key);
        }

        private void button_Click(object sender, RoutedEventArgs e)

        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("There is no selected item..Please select an item or click on Back button.");
            }
            else
            {
                Admin ad = new Admin();
                ad.RemoveStudent(comboBox.SelectedItem.ToString());
                MessageBox.Show("Student is removed.");
                comboBox.SelectedIndex = -1;
            }

        }
    }
}
