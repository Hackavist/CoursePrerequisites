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
            WelcomePage.Course.WriteFile();
            WelcomePage.Student.WriteFile();
            WelcomePage.Admin.WriteFile();
        }
    }
}
