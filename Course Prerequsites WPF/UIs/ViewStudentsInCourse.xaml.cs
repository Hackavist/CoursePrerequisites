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
    /// Interaction logic for ViewStudentsInCourse.xaml
    /// </summary>
    public partial class ViewStudentsInCourse : Window
    {
        public ViewStudentsInCourse()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchCourseName.Text))
            {
                MessageBox.Show("Please Enter Course Name");
            }
            else
            {
                string name = SearchCourseName.Text;
                Student s = new Student();
                List<Course> listOfCourses = s.CoursesInProgress;

                if (MainWindow.AllCoursesDictionary.ContainsKey(name))
                {
                    for (int i = 0; i < MainWindow.AllStudentsDictionary.Count; i++)
                    {
                        for (int j = 0; j < listOfCourses.Count; j++)
                        {
                            if (listOfCourses[i].CourseName == name)
                            {
                                DisplayID.Content += s.Id + '\n';
                                DisplayName.Content += s.Name + '\n';
                            }
                            break;

                        }
                    }



                }
                else
                {
                    MessageBox.Show("Course Does Not Exist");
                }

            }
        }
    }
}
