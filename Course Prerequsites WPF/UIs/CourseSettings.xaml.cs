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
using Course_Prerequsites_WPF.UIs;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for CourseSettings.xaml
    /// </summary>
    public partial class CourseSettings : Window
    {
        public CourseSettings()
        {
            InitializeComponent();
        }

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
            AddNewCourse AddCourse = new AddNewCourse();
            AddCourse.Show();
            this.Close();
        }

        private void EditCourse_Click(object sender, RoutedEventArgs e)
        {
            EditCourse ad = new UIs.EditCourse();
            ad.Show();
            this.Close();
        }

        private void ViewStudentsInCourse_Click(object sender, RoutedEventArgs e)
        {
            // view all students in a course
            ViewStudentsInCourse viewStud = new ViewStudentsInCourse();
            viewStud.Show();
            this.Close();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            //opens next window : admin controls
            ViewStudentOrCourse AdminControls = new ViewStudentOrCourse();
            AdminControls.Show();
            this.Close();
        }

        private void dropacoursebutton_Click(object sender, RoutedEventArgs e)
        {
            Drop drp = new Drop();
            drp.Show();
            this.Close();
        }


    }
}
