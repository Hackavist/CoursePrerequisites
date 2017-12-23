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
        }

      

        private void StudentSettings_Click(object sender, RoutedEventArgs e)
        {
            StudentsSettings StudSettings = new StudentsSettings();
            StudSettings.Show();
            this.Hide();
            this.Close();
        }

        private void AdminSettings_Click_1(object sender, RoutedEventArgs e)
        {
            AdminSettings AdSettings = new AdminSettings();
            AdSettings.Show();
            this.Hide();
            this.Close();
        }

        private void CourseSettings_Click(object sender, RoutedEventArgs e)
        {
            //course settings
            CourseSettings CourSettings = new CourseSettings();
            this.Hide();
            this.Close();
        }
    }
}
