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

using Course_Prerequsites_WPF.UIs;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for ViewStudentOrCourse.xaml
    /// </summary>
    public partial class ViewStudentOrCourse : Window
    {
        public ViewStudentOrCourse()
        {
            InitializeComponent();

            if (WelcomePage.AllAdminsDictionary[WelcomePage.AdminUserName].GeneralManager != 1)
            {
                AdminSettings.Visibility = Visibility.Hidden;
            }
            else
            {
                AdminSettings.Visibility = Visibility.Visible;
            }
        }

        private void StudentSettings_Click(object sender, RoutedEventArgs e)
        {
            StudentsSettings StudSettings = new StudentsSettings();
            StudSettings.Show();
            this.Close();
        }

        private void AdminSettings_Click_1(object sender, RoutedEventArgs e)
        {
            AdminSettings AdSettings = new AdminSettings();
            AdSettings.Show();
            this.Close();
        }

        private void CourseSettings_Click(object sender, RoutedEventArgs e)
        {
            //course settings
            CourseSettings CourSettings = new CourseSettings();
            CourSettings.Show();
            this.Close();
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage.AdminLogedIn = false;
            WelcomePage.AdminUserName = "";
            WelcomePage.AdminPassword = "";
            WelcomePage wel = new WelcomePage();
            wel.Show();
            this.Close();
        }
    }
}
