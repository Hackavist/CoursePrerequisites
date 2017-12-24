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

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for Add_Admin.xaml
    /// </summary>
    public partial class Add_Admin : Window
    {
        public Add_Admin()
        {
            InitializeComponent();
        }

        bool PasswordLengthChecker(string pass)
        {
            if ((pass.Length > 8) && (pass.Length < 64))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password Length Must be between 8 and 64");
                return false;
            }
        }
        private void Add_MouseUp(object sender, MouseButtonEventArgs e)
        {
            int IsGeneralManager = 0;

            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please enter missing data");
            }
            else
            {

                if (PasswordLengthChecker(Password.Text))
                {
                    if ((WelcomePage.ThereIsNoDelimiter(Username.Text)) && (WelcomePage.ThereIsNoDelimiter(Password.Text)))
                    {
                        if (GeneralManagerCheck.IsChecked == true)
                        {
                            IsGeneralManager = 1;
                        }
                        Admin admin = new Admin(Username.Text, Password.Text, IsGeneralManager);

                        WelcomePage.AllAdminsDictionary[Username.Text] = admin;
                        MessageBox.Show("Admin Has Been Added");
                    }
                    else
                    {
                        MessageBox.Show("The Provided text Can't contain any of the following Character");
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            AdminSettings ad = new AdminSettings();
            ad.Show();
            this.Close();
        }
    }
}
