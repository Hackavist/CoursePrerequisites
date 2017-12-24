﻿using System;
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
    /// Interaction logic for EditCourse.xaml
    /// </summary>
    /// Made By Hazem Khairy ^_^
    public partial class EditCourse : Window
    {
        public EditCourse()
        {
            InitializeComponent();
            InnerCanvas.Visibility = System.Windows.Visibility.Hidden;
            //put all courses in the combo box
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                CourseSelection.Items.Add(x.Value.CourseName);
            }
            // add tooltip for each textbox
            HoursTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of hours Must not exceed 6";
            MaximumNumberOfStudentsTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of students Must not exceed 500";
            CurrentNumberOfStudentsTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of Current students Must not the maximum";
            CourseGradeTextBox.ToolTip = "-Text Box can only contain numbers \n -Course Grade Must not exceed 200";
            PassingGradeTextBox.ToolTip = "-Text Box can only contain numbers \n -Course Grades Must no exceed Course Grades ";
        }

        Course SelectedCourse;

        private void CourseSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //makes the info box visible
            InnerCanvas.Visibility = System.Windows.Visibility.Visible;
            // get the selected Course
            SelectedCourse = WelcomePage.AllCoursesDictionary[CourseSelection.SelectedValue.ToString()];
            //puts the old selected student info in the text boxes
            MaximumNumberOfStudentsTextBox.Text = SelectedCourse.MaximumNumberOfStudents.ToString();
            CurrentNumberOfStudentsTextBox.Text = SelectedCourse.CurrentNumberOfStudents.ToString();
            HoursTextBox.Text = SelectedCourse.Hours.ToString();
            PassingGradeTextBox.Text = SelectedCourse.PassingGrade.ToString();
            CourseGradeTextBox.Text = SelectedCourse.CourseGrade.ToString();
            InstructorTextBox.Text = SelectedCourse.Instructor;
            DescriptionTextBox.Text = SelectedCourse.Description;

        }
        bool CheckNumberOfStudentsTextBoxes()
        {
            if (WelcomePage.IsNumber(CurrentNumberOfStudentsTextBox.Text) == false)
            {
                MessageBox.Show("Text Box of Current Number of Students must have only integer numbers .");
                return false;
            }
            else if (WelcomePage.IsNumber(MaximumNumberOfStudentsTextBox.Text) == false)
            {
                MessageBox.Show("Text Box of Maximum Number of Students must have only integer numbers .");
                return false;
            }
            else if (int.Parse(MaximumNumberOfStudentsTextBox.Text) < int.Parse(CurrentNumberOfStudentsTextBox.Text))
            {
                MessageBox.Show("The Current Number of student of this course exceeds the maximum number");
                return false;
            }
            else if (int.Parse(MaximumNumberOfStudentsTextBox.Text) > 500)
            {
                MessageBox.Show("The Maximum number of students in class cannot exceed 500 student");
                return false;
            }
            return true;
        }
        bool CheckIfThereIsEmptyTextBox()
        {
            // check if there is empty text box 
            if (MaximumNumberOfStudentsTextBox.Text.Length == 0 || CurrentNumberOfStudentsTextBox.Text.Length == 0 || PassingGradeTextBox.Text.Length == 0 || CourseGradeTextBox.Text.Length == 0 || HoursTextBox.Text.Length == 0 || InstructorTextBox.Text.Length == 0 || DescriptionTextBox.Text.Length == 0)
                return true;
            return false;
        }


        bool CheckGradesTextBoxes()
        {
            if (WelcomePage.IsNumber(CourseGradeTextBox.Text) == false)
            {
                MessageBox.Show("The Text box of Course Grade must have only integer Number ");
                return false;
            }
            else if (WelcomePage.IsNumber(PassingGradeTextBox.Text) == false)
            {
                MessageBox.Show("The Text box of Passing Grade must have only integer Number ");
                return false;
            }
            else if (int.Parse(PassingGradeTextBox.Text) >= int.Parse(CourseGradeTextBox.Text))
            {
                MessageBox.Show("Passing Grade of course cannot exceed the course Grade");
                return false;
            }
            else if (int.Parse(CourseGradeTextBox.Text) > 200)
            {
                MessageBox.Show("Course Grade cannot exceed 200");
                return false;
            }
            return true;
        }
        bool CheckHoursTextBox()
        {
            if (WelcomePage.IsNumber(HoursTextBox.Text) == false)
            {
                MessageBox.Show("The Text box of hours must have only integer Number ");
                return false;
            }
            else if (int.Parse(HoursTextBox.Text) > 6)
            {
                MessageBox.Show("The Hours cannot exceed 6 hours");
                return false;
            }
            return true;
        }
        bool CheckAllTheRemainingTextBoxes()
        {
            //check if there is delimiter in Instructor text box or Description text box
            if (WelcomePage.ThereIsNoDelimiter(InstructorTextBox.Text) && WelcomePage.ThereIsNoDelimiter(DescriptionTextBox.Text))
            {
                return true;

            }
            MessageBox.Show("There is some text box contains '%' or '#' or '*' ");
            return false;
        }
        void mytrimer()
        {
            MaximumNumberOfStudentsTextBox.Text = MaximumNumberOfStudentsTextBox.Text.Trim(' ', '\0');
            CourseGradeTextBox.Text = CourseGradeTextBox.Text.Trim(' ', '\0');
            PassingGradeTextBox.Text = PassingGradeTextBox.Text.Trim(' ', '\0');
            CurrentNumberOfStudentsTextBox.Text = CurrentNumberOfStudentsTextBox.Text.Trim(' ', '\0');
            HoursTextBox.Text = HoursTextBox.Text.Trim(' ', '\0');
            InstructorTextBox.Text = InstructorTextBox.Text.Trim(' ', '\0');
            DescriptionTextBox.Text = DescriptionTextBox.Text.Trim(' ', '\0');

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mytrimer();
            if (CheckIfThereIsEmptyTextBox() == true)
            {
                MessageBox.Show("You cannot leave empty text box");
                return;
            }
            else
            {
                if (CheckNumberOfStudentsTextBoxes() && CheckGradesTextBoxes() && CheckHoursTextBox() && CheckAllTheRemainingTextBoxes())
                {
                    SelectedCourse.MaximumNumberOfStudents = int.Parse(MaximumNumberOfStudentsTextBox.Text);
                    SelectedCourse.CurrentNumberOfStudents = int.Parse(CurrentNumberOfStudentsTextBox.Text);
                    SelectedCourse.CourseGrade = int.Parse(CourseGradeTextBox.Text);
                    SelectedCourse.PassingGrade = int.Parse(PassingGradeTextBox.Text);
                    SelectedCourse.Description = DescriptionTextBox.Text.ToString();
                    WelcomePage.AllCoursesDictionary[SelectedCourse.CourseName] = SelectedCourse;
                    MessageBox.Show("Done Editting ^_^");
                }
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            CourseSettings cour = new CourseSettings();
            cour.Show();
            this.Close();
        }
    }
}
