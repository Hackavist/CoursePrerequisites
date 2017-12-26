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
    /// Interaction logic for AddNewCourse.xaml
    /// </summary>
    /// Made By : Hazem Khairy ^_^
    public partial class AddNewCourse : Window
    {
        public AddNewCourse()
        {
            InitializeComponent();

            HoursTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of hours must not exceed 6.";
            MaximumNumberOfStudentsTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of students must not exceed 500.";
            CurrentNumberOfStudentsTextBox.ToolTip = "-Textbox can only contain numbers. \n -Number of current students must not exceed the maximum number of students.";
            CourseGradeTextBox.ToolTip = "-Textbox can only contain numbers. \n -Course grade must not exceed 200.";
            PassingGradeTextBox.ToolTip = "-Textbox can only contain numbers. \n -Passing grade must no exceed the course grade.";
        }
        void mytrimer()
        {
            CodeTextBox.Text = CodeTextBox.Text.Trim(' ', '\0');
            CourseNameTextBox.Text = CourseNameTextBox.Text.Trim(' ', '\0');
            MaximumNumberOfStudentsTextBox.Text = MaximumNumberOfStudentsTextBox.Text.Trim(' ', '\0');
            CourseGradeTextBox.Text = CourseGradeTextBox.Text.Trim(' ', '\0');
            PassingGradeTextBox.Text = PassingGradeTextBox.Text.Trim(' ', '\0');
            CurrentNumberOfStudentsTextBox.Text = CurrentNumberOfStudentsTextBox.Text.Trim(' ', '\0');
            HoursTextBox.Text = HoursTextBox.Text.Trim(' ', '\0');
            InstructorTextBox.Text = InstructorTextBox.Text.Trim(' ', '\0');
            DescriptionTextBox.Text = DescriptionTextBox.Text.Trim(' ', '\0');

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
                MessageBox.Show("The current number of students in this course exceeds the maximum number.");
                return false;
            }
            else if (int.Parse(MaximumNumberOfStudentsTextBox.Text) > 500)
            {
                MessageBox.Show("The maximum number of students in class cannot exceed 500 students.");
                return false;
            }
            return true;
        }

        bool CheckGradesTextBoxes()
        {
            if (WelcomePage.IsNumber(CourseGradeTextBox.Text) == false)
            {
                MessageBox.Show("The textbox of course grade must have only integer numbers.");
                return false;
            }
            else if (WelcomePage.IsNumber(PassingGradeTextBox.Text) == false)
            {
                MessageBox.Show("The textbox of passing grade must have only integer numbers.");
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
            if (WelcomePage.ThereIsNoDelimiter(CodeTextBox.Text) && WelcomePage.ThereIsNoDelimiter(CourseNameTextBox.Text) && WelcomePage.ThereIsNoDelimiter(InstructorTextBox.Text) && WelcomePage.ThereIsNoDelimiter(DescriptionTextBox.Text))
            {
                return true;
            }
            MessageBox.Show("Some textbox contains '%' or '#' or '*'.");
            return false;
        }
        public static List<string> CoursePrerequstiesTmp;
        bool CheckIfThereIsEmptyTextBox()
        {
            if (CodeTextBox.Text.Length == 0 || CourseNameTextBox.Text.Length == 0 || MaximumNumberOfStudentsTextBox.Text.Length == 0 || CurrentNumberOfStudentsTextBox.Text.Length == 0 || PassingGradeTextBox.Text.Length == 0 || CourseGradeTextBox.Text.Length == 0 || HoursTextBox.Text.Length == 0 || InstructorTextBox.Text.Length == 0 || DescriptionTextBox.Text.Length == 0)
                return true;
            return false;
        }
        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            mytrimer();
            if (CheckIfThereIsEmptyTextBox())
            {
                MessageBox.Show("Some textbox is missing.");
            }
            else
            {
                if (CheckNumberOfStudentsTextBoxes() && CheckGradesTextBoxes() && CheckHoursTextBox() && CheckAllTheRemainingTextBoxes())
                {
                    string Code = CodeTextBox.Text;
                    string CourseName = CourseNameTextBox.Text;
                    int MaximumNumber = int.Parse(MaximumNumberOfStudentsTextBox.Text);
                    int CurrentNumber = int.Parse(CurrentNumberOfStudentsTextBox.Text);
                    int PassingGrade = int.Parse(PassingGradeTextBox.Text);
                    int CourseGrade = int.Parse(CourseGradeTextBox.Text);
                    int Hours = int.Parse(HoursTextBox.Text);
                    string Instructor = InstructorTextBox.Text;
                    string Description = DescriptionTextBox.Text;
                    CoursePrerequstiesTmp = new List<string>();

                    if (WelcomePage.AllCoursesDictionary.ContainsKey(CourseName))
                    {
                        MessageBox.Show("This course already exists.");
                    }
                    else
                    {
                        AddNewCourseSecondStep nw = new AddNewCourseSecondStep();
                        nw.ShowDialog();
                        Course newcourse = new Course(Code, CourseName, MaximumNumber, CurrentNumber, PassingGrade, CourseGrade, Hours, Instructor, Description, CoursePrerequstiesTmp);
                        WelcomePage.AllCoursesDictionary[CourseName] = newcourse;
                        CodeTextBox.Clear();
                        CourseNameTextBox.Clear();
                        MaximumNumberOfStudentsTextBox.Clear();
                        //CurrentNumberOfStudentsTextBox.Clear();
                        PassingGradeTextBox.Clear();
                        CourseGradeTextBox.Clear();
                        HoursTextBox.Clear();
                        InstructorTextBox.Clear();
                        DescriptionTextBox.Clear();
                    }
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