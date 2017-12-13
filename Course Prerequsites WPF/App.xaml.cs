using System;
using System.Windows;
using System.IO;
using Course_Prerequsites_WPF.Classes;
using Course_Prerequsites_WPF.UIs;

namespace Course_Prerequsites_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {

            //clears the previous files 
            WelcomePage.Course.FileClear();
            WelcomePage.Student.FileClear();
            WelcomePage.Admin.FileClear();

            //writes the whole file for each classs
            WelcomePage.Course.WriteFile();
            WelcomePage.Student.WriteFile();
            WelcomePage.Admin.WriteFile();

            // Logs the student out 
            WelcomePage.StudentLogedIn = false;
            WelcomePage.StudentId = "";
            WelcomePage.StudentPassword = "";

            //logs the admin out
            WelcomePage.AdminLogedIn = false;
            WelcomePage.AdminUserName = "";
            WelcomePage.AdminPassword = "";
        }
    }
}
