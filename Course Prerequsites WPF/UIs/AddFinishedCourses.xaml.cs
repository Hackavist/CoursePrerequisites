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
    /// Interaction logic for AddFinishedCourses.xaml
    /// </summary>
    public partial class AddFinishedCourses : Window
    {
        public AddFinishedCourses()
        {
            InitializeComponent();


            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                if (x.Value.AcademicYear != "1st year")
                {
                    if (x.Value.FinishedCourses.Count == 0)
                    {

                        Students.Items.Add(x.Value.Name);

                    }
                }
            }

            CourseLabel.Visibility = Visibility.Hidden;
            Courses.Visibility = Visibility.Hidden;

            CourseLabel_Copy.Visibility = Visibility.Hidden;
            Courses_Copy.Visibility = Visibility.Hidden;


            MoreCourses.Visibility = Visibility.Hidden;
            MoreCourses_Copy.Visibility = Visibility.Hidden;

        }

        private void Students_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CourseLabel.Visibility = Visibility.Visible;
            Courses.Visibility = Visibility.Visible;

            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                Courses.Items.Add(x.Value.CourseName);
            }

        }

        private void Courses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MoreCourses.Visibility = Visibility.Visible;
        }

        private void MoreCourses_Click(object sender, RoutedEventArgs e)
        {
            CourseLabel_Copy.Visibility = Visibility.Visible;
            Courses_Copy.Visibility = Visibility.Visible;

            MoreCourses_Copy.Visibility = Visibility.Visible;

        }
    }
}
