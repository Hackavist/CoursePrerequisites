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

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for StudentLogIn.xaml
    /// </summary>
    public partial class StudentLogIn : Window
    {
        public static string StudentID ;
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            StudentID = idTextBox.Text;
            string password = passwordTextBox.Text;
            if (StudentID=="" || password=="")
            {
                MessageBox.Show("Please enter valid username and password.");
            }
            else
            {
                if (WelcomePage.AllStudentsDictionary.ContainsKey(StudentID))
                {
                    if (WelcomePage.AllStudentsDictionary[StudentID].Password==password)
                    {
                        MessageBox.Show("WE ARE DONE!!!");
                        WelcomePage.StudentLogedIn = true;
                        WelcomePage.StudentId = idTextBox.Text;
                        WelcomePage.StudentPassword = passwordTextBox.Text;
                        RegisterToNewCouse reg = new RegisterToNewCouse();
                        reg.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong password.");
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist.");
                }
            }
        }

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
