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
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(idTextBox.Text) || string.IsNullOrEmpty(Password_txt.Password))
            {
                MessageBox.Show("Please enter valid username and password.");
            }
            else
            {
                if (WelcomePage.AllStudentsDictionary.ContainsKey(idTextBox.Text))
                {
                    if (WelcomePage.AllStudentsDictionary[idTextBox.Text].Password == Password_txt.Password)
                    {
                        MessageBox.Show("Logging in...");
                        WelcomePage.StudentLogedIn = true;
                        WelcomePage.StudentId = idTextBox.Text;
                        WelcomePage.StudentPassword = Password_txt.Password;

                        StudentControls StudControls = new StudentControls();
                        StudControls.Show();
                        this.Hide();
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

        private void Password_txt_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Password_txt.Password.Length > 0)
            {
                EyeImage.Visibility = Visibility.Visible;
            }
            else
            {
                EyeImage.Visibility = Visibility.Hidden;
            }
        }

        private void EyeImage_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPassword();
        }

        private void EyeImage_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            HidePassword();
        }

        private void EyeImage_MouseLeave(object sender, MouseEventArgs e)
        {
            HidePassword();
        }

        private void ShowPassword()
        {
            Password_txt.Visibility = Visibility.Hidden;
            VisiblePass_txt.Visibility = Visibility.Visible;
            VisiblePass_txt.Text = Password_txt.Password;
        }

        private void HidePassword()
        {
            Password_txt.Visibility = Visibility.Visible;
            VisiblePass_txt.Visibility = Visibility.Hidden;
            Password_txt.Focus();

        }
    }
}
