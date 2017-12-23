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
    /// Interaction logic for StudentsSettings.xaml
    /// </summary>
    public partial class StudentsSettings : Window
    {
        public StudentsSettings()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStud = new AddStudent();
            addStud.Show();
            this.Hide();
            this.Close();
        }

        private void ViewAllCoursesOfStudentbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewAllCoursesOfStudent viewCourses = new ViewAllCoursesOfStudent();
            viewCourses.Show();
            this.Hide();
            this.Close();

            
        }
    }
}
