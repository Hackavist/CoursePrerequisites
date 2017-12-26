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
using Course_Prerequsites_WPF.Classes;
using System.IO;

namespace Course_Prerequsites_WPF.UIs

{
    /// <summary>
    /// Interaction logic for AdminLogIn.xaml
    /// </summary>
    /// 

    public partial class AdminLogIn : Window
    {
        // string appPath = Directory.GetCurrentDirectory();

        public AdminLogIn()
        {
            InitializeComponent();
            //  EyeImage.Source = new BitmapImage(new Uri(uriString: $"{appPath}\\Images\\eye.png"));
        }

        private void LogIn_txt_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Username_txt.Text) || string.IsNullOrEmpty(Password_txt.Password))
            {
                MessageBox.Show("Please enter the missing data.");
            }

            else
            {

                string name = Username_txt.Text;
                string password = Password_txt.Password;

                if (WelcomePage.AllAdminsDictionary.ContainsKey(name))
                {
                    if (WelcomePage.AllAdminsDictionary[name].Password == password)
                    {
                        MessageBox.Show("Logging in..");

                        WelcomePage.AdminLogedIn = true;
                        WelcomePage.AdminUserName = name;
                        WelcomePage.AdminPassword = password;

                        //opens next window : admin controls
                        ViewStudentOrCourse AdminControls = new ViewStudentOrCourse();
                        AdminControls.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.");
                    }
                }
                else
                {
                    MessageBox.Show("Admin does not exist.");
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

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage wel = new WelcomePage();
            wel.Show();
            this.Close();
        }
    }
}
