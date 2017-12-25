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
    /// Interaction logic for ViewAllCoursesOfStudent.xaml
    /// </summary>
    /// Made By : Hazem Khairy ^_^
    public partial class ViewAllCoursesOfStudent : Window
    {
        public ViewAllCoursesOfStudent()
        {
            InitializeComponent();
            InfoBlock.Visibility = System.Windows.Visibility.Hidden;
        }
        List<string> InProgress;
        List<string> Finished;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                SelectStudentComboBox.Items.Add(x.Key + ' ' + x.Value.Name);
            }
        }
        void DisplayCourseDetails(string coursename)
        {
            Course tmp = WelcomePage.AllCoursesDictionary[coursename];
            InfoBlock.Visibility = System.Windows.Visibility.Visible;
            NameTextBlock.Text = "Course Name : " + tmp.CourseName;
            CodeTextBlock.Text = "Course Code : " + tmp.Code;
            CurrentstudentTextBlock.Text = "Current Number of Students : " + tmp.CurrentNumberOfStudents;
            MaximumStudentTextBlock.Text = "Maximum Number of Students : " + tmp.MaximumNumberOfStudents;
            PassingGradeTextBlock.Text = "Passing Grade : " + tmp.PassingGrade.ToString();
            MaxGradeTextBlock.Text = "Total Grade : " + tmp.CourseGrade.ToString();
            HoursTextBlock.Text = "Total Hours : " + tmp.Hours.ToString();
            InstructorTextBlock.Text = "Instructor Name : " + tmp.Instructor;
            DescriptionTextBlock.Text = "Description : " + tmp.Description;
        }

        private void ListOfProgressCoursesOfStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListOfProgressCoursesOfStudent.SelectedIndex != -1)
            {
                DisplayCourseDetails(ListOfProgressCoursesOfStudent.SelectedValue.ToString());
            }
            else
            {
                InfoBlock.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void ListOfCompletedCoursesOfStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ListOfCompletedCoursesOfStudent.SelectedIndex != -1)
            {
                DisplayCourseDetails(ListOfCompletedCoursesOfStudent.SelectedValue.ToString());
            }
            else
            {
                InfoBlock.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void SelectStudentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListOfCompletedCoursesOfStudent.Items.Clear();
            ListOfProgressCoursesOfStudent.Items.Clear();
            if (SelectStudentComboBox.SelectedIndex != -1)
            {

                string[] tosperate = SelectStudentComboBox.SelectedItem.ToString().Split(' ');
                string SelectedId = tosperate[0];
                InProgress = Admin.GetInProgressCoursesOfSpecificStudent(SelectedId);
                Finished = Admin.GetAllFinsishedCoursesOfSpecificStudent(SelectedId);
                foreach (var x in InProgress)
                {
                    ListOfProgressCoursesOfStudent.Items.Add(x);
                }
                foreach (var x in Finished)
                {
                    ListOfCompletedCoursesOfStudent.Items.Add(x);
                }
            }
            else
                MessageBox.Show("Please select a student to view their courses.");
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentsSettings st = new StudentsSettings();
            st.Show();
            this.Close();
        }
    }
}
