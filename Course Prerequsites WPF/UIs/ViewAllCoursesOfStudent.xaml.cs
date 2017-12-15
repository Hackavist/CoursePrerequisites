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
    /// Interaction logic for ViewAllCoursesOfStudent.xaml
    /// </summary>
    public partial class ViewAllCoursesOfStudent : Window
    {
        public ViewAllCoursesOfStudent()
        {
            InitializeComponent();
        }
        private void View_button_Click(object sender, RoutedEventArgs e)
        {
            // clear the list if there were exist 
            ListOfCompletedCoursesOfStudent.Items.Clear();
            ListOfProgressCoursesOfStudent.Items.Clear();
            if (SelectStudentComboBox.SelectedItem == null)
            {
                MessageBox.Show("please select a student to view his courses");
            }
            else
            {
                string selectedstudent = SelectStudentComboBox.SelectedValue.ToString();
                if (WelcomePage.AllStudentsDictionary[selectedstudent].CoursesInProgress.Count == 0)
                {
                    ListOfProgressCoursesOfStudent.Items.Add("This student have no courses in progress");
                }
                else
                {

                    foreach (var x in WelcomePage.AllStudentsDictionary[selectedstudent].CoursesInProgress)
                    {
                        ListOfProgressCoursesOfStudent.Items.Add(x.CourseName);
                    }
                }
                
                if (WelcomePage.AllStudentsDictionary[selectedstudent].FinishedCourses.Count == 0)
                {
                    ListOfCompletedCoursesOfStudent.Items.Add("This student have no finished courses");
                }
                else
                {

                    foreach (var x in WelcomePage.AllStudentsDictionary[selectedstudent].FinishedCourses)
                    {
                        ListOfCompletedCoursesOfStudent.Items.Add(x.CourseName);
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                SelectStudentComboBox.Items.Add(x.Key);
            }
        }
    }
}
