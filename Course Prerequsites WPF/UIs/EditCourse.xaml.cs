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
            HoursTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of hours must not exceed 6.";
            MaximumNumberOfStudentsTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of students must not exceed 500.";
            CurrentNumberOfStudentsTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of current students must not exceed the maximum number of students.";
            CourseGradeTextBox.ToolTip = "-Textbox can only contain numbers. \n -Course grade must not exceed 200.";
            PassingGradeTextBox.ToolTip = "-Textbox can only contain numbers. \n -Passing grade must no exceed the course grade.";
        }

        public static Course SelectedCourse;

        private void CourseSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CourseSelection.SelectedIndex!=-1)
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
            else
            {
                InnerCanvas.Visibility = System.Windows.Visibility.Hidden;
            }

        }
        bool CheckNumberOfStudentsTextBoxes()
        {
            if (WelcomePage.IsNumber(CurrentNumberOfStudentsTextBox.Text) == false)
            {
                MessageBox.Show("Textbox of current number of students must have only integer numbers.");
                return false;
            }
            else if (WelcomePage.IsNumber(MaximumNumberOfStudentsTextBox.Text) == false)
            {
                MessageBox.Show("Textbox of maximum number of students must have only integer numbers.");
                return false;
            }
            else if (int.Parse(MaximumNumberOfStudentsTextBox.Text) < int.Parse(CurrentNumberOfStudentsTextBox.Text))
            {
                MessageBox.Show("The current number of student in this course exceeds the maximum number.");
                return false;
            }
            else if (int.Parse(MaximumNumberOfStudentsTextBox.Text) > 500)
            {
                MessageBox.Show("The maximum number of students in class cannot exceed 500 students.");
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
                MessageBox.Show("The textbox of course grade must have only integer number.");
                return false;
            }
            else if (WelcomePage.IsNumber(PassingGradeTextBox.Text) == false)
            {
                MessageBox.Show("The textbox of passing grade must have only integer number.");
                return false;
            }
            else if (int.Parse(PassingGradeTextBox.Text) >= int.Parse(CourseGradeTextBox.Text))
            {
                MessageBox.Show("Passing grade of course cannot exceed the course grade.");
                return false;
            }
            else if (int.Parse(CourseGradeTextBox.Text) > 200)
            {
                MessageBox.Show("Course grade cannot exceed 200.");
                return false;
            }
            return true;
        }
        bool CheckHoursTextBox()
        {
            if (WelcomePage.IsNumber(HoursTextBox.Text) == false)
            {
                MessageBox.Show("The hours textbox can only contain integer numbers.");
                return false;
            }
            else if (int.Parse(HoursTextBox.Text) > 6)
            {
                MessageBox.Show("The hours cannot exceed 6 hours.");
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
            MessageBox.Show("Some textbox contains '%' or '#' or '*'.");
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
                MessageBox.Show("You cannot leave an empty textbox.");
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
                    MessageBox.Show("Done editing.");
                }
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            CourseSettings cour = new CourseSettings();
            cour.Show();
            this.Close();
        }

        private void EditPrerequsitesButton_Click(object sender, RoutedEventArgs e)
        {
            EditCoursePrerequsites secondstep = new EditCoursePrerequsites();
            secondstep.ShowDialog();

        }
    }
}
