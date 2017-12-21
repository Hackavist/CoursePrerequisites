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
using System.IO;
using Course_Prerequsites_WPF.Classes;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for EditMyData.xaml
    /// </summary>
    public partial class EditMyData : Window
    {
        
        public EditMyData()
        {
            InitializeComponent();
        }
        
        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ayTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            idTextBox.Text = WelcomePage.StudentId;
            nameTextBox.Text = WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].Name;
            passwordBox.Password = WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].Password;
            ayTextBox.Text = WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].AcademicYear.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].Name = nameTextBox.Text;
            WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].Password = passwordBox.Password;
        }
    }
}
