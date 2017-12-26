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
    /// Interaction logic for RegisterToNewCouse.xaml
    /// </summary>
    public partial class RegisterToNewCouse : Window
    {
        public RegisterToNewCouse()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Student s = new Student();
          
                //Loop on all available courses for this student in the list that is returned from this function
                foreach (var x in s.ShowAvailableCourses())
                {
                    //Add this courses to the combo box
                    AvailableCourseBox.Items.Add(x);
                }
                //If no avilable courses this message will appear
                if (AvailableCourseBox.Items.Count == 0)
                {
                    MessageBox.Show("You have no available courses right now." + '\n' + "Please click on the back button.");

                }
            }
       

        //What will happened when click on register
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            if (AvailableCourseBox.SelectedIndex == -1)
            {
                MessageBox.Show("There is no selected item. Please select an item or click on the back button.");
            }
            else if (s.IsAvailableCreditHours(WelcomePage.AllStudentsDictionary[WelcomePage.StudentId], WelcomePage.Course.ReturnObj(AvailableCourseBox.SelectionBoxItem.ToString())) == false)
            {
                MessageBox.Show("You can't take more than 20 credit hours in one semster." + '\n' + "You are not allowed to register right now.");

            }
            else
            {
                //Object that contain the selected item in combo box
                Course c = WelcomePage.Course.ReturnObj(AvailableCourseBox.SelectionBoxItem.ToString());
                //Add this course to the courses in progress for this student
                WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].CoursesInProgress.Add(c);
                //When this student regist to aspecific course the number of students in this course will be incremented
                WelcomePage.AllCoursesDictionary[AvailableCourseBox.SelectionBoxItem.ToString()].CurrentNumberOfStudents++;
                //The Message that appears
                MessageBox.Show("Successfully registered to " + AvailableCourseBox.SelectionBoxItem.ToString());
                //When you regist to this course it will be removed from combo box
                AvailableCourseBox.Items.Remove(AvailableCourseBox.SelectionBoxItem.ToString());
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentControls stud = new StudentControls();
            stud.Show();
            this.Close();
        }
    }
}

