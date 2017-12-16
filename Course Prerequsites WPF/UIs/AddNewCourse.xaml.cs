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
    public partial class AddNewCourse : Window
    {
        public AddNewCourse()
        {
            InitializeComponent();

            AddCourseButton_second.Visibility = System.Windows.Visibility.Hidden;
            CoursePrequestiesComboBox.Visibility = System.Windows.Visibility.Hidden;
            TmpLabel.Visibility = System.Windows.Visibility.Hidden;
            HoursTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of hours Must not exceed 6";
            MaximumNumberOfStudentsTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of students Must not exceed 500";
            CurrentNumberOfStudentsTextBox.ToolTip = "-Text Box can only contain numbers \n -Number of Current students Must not the maximum";
            CourseGradeTextBox.ToolTip = "-Text Box can only contain numbers \n -Course Grade Must not exceed 200";
            PassingGradeTextBox.ToolTip = "-Text Box can only contain numbers \n -Course Grades Must no exceed Course Grades ";
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                CoursePrequestiesComboBox.Items.Add(x.Key);
            }
        }
        void mytrimer()
        {
            CodeTextBox.Text = CodeTextBox.Text.Trim();
            nam
        }
        bool CheckNumberOfStudentsTextBoxes()
        {
            if (WelcomePage.IsNumber(CurrentNumberOfStudentsTextBox.Text)==false)
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
            else if (int.Parse(PassingGradeTextBox.Text)>=int.Parse(CourseGradeTextBox.Text))
            {
                MessageBox.Show("Passing Grade of course cannot exceed the course Grade");
                return false;
            }
            else if (int.Parse(CourseGradeTextBox.Text) >200)
            {
                MessageBox.Show("Course Grade cannot exceed 200");
                return false;
            }
            return true;
        }
        bool CheckHoursTextBox()
        {
            if (WelcomePage.IsNumber(HoursTextBox.Text)==false )
            {
                MessageBox.Show("The Text box of hours must have only integer Number ");
                return false;
            }
            else if (int.Parse(HoursTextBox.Text)>6)
            {
                MessageBox.Show("The Hours cannot exceed 6 hours");
                return false;
            }
            return true;
        }
        bool CheckAllTheRemainingTextBoxes()
        {
            if (WelcomePage.ThereIsNoDelimiter(CodeTextBox.Text)&&WelcomePage.ThereIsNoDelimiter(CourseNameTextBox.Text)&&WelcomePage.ThereIsNoDelimiter(InstructorTextBox.Text)&&WelcomePage.ThereIsNoDelimiter(DescriptionTextBox.Text))
            {
            return true;

            }
            MessageBox.Show("There is some text box contains '%' or '#' or '*' ");
            return false;
        }
        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTextBox.Text.Length == 0 || CourseNameTextBox.Text.Length == 0 || MaximumNumberOfStudentsTextBox.Text.Length == 0 || CurrentNumberOfStudentsTextBox.Text.Length == 0 || PassingGradeTextBox.Text.Length == 0 || CourseGradeTextBox.Text.Length == 0 || HoursTextBox.Text.Length == 0 || InstructorTextBox.Text.Length == 0 || DescriptionTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is missing");
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
                    int CourseGrade = int.Parse(CourseNameTextBox.Text);
                    int Hours = int.Parse(HoursTextBox.Text);
                    string Instructor = InstructorTextBox.Text;
                    string Description = DescriptionTextBox.Text;
                    List<string> tmp = new List<string>();

                    if (WelcomePage.AllCoursesDictionary.ContainsKey(CourseName))
                    {
                        MessageBox.Show("This course already exists ");

                    }
                    else
                    {

                        Course newcourse = new Course(Code, CourseName, MaximumNumber, CurrentNumber, PassingGrade, CourseGrade, Hours, Instructor, Description, tmp);
                        WelcomePage.AllCoursesDictionary[CourseName] = newcourse;
                    }
                }
            }
        }

        private void EditCourseButton_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTextBox.Text.Length == 0 || CourseNameTextBox.Text.Length == 0 || MaximumNumberOfStudentsTextBox.Text.Length == 0 || CurrentNumberOfStudentsTextBox.Text.Length == 0 || PassingGradeTextBox.Text.Length == 0 || CourseGradeTextBox.Text.Length == 0 || HoursTextBox.Text.Length == 0 || InstructorTextBox.Text.Length == 0 || DescriptionTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is missing");
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
                    int CourseGrade = int.Parse(CourseNameTextBox.Text);
                    int Hours = int.Parse(HoursTextBox.Text);
                    string Instructor = InstructorTextBox.Text;
                    string Description = DescriptionTextBox.Text;

                    List<string> tmp = new List<string>();

                    if (WelcomePage.AllCoursesDictionary.ContainsKey(CourseName))
                    {
                        Course newcourse = new Course(Code, CourseName, MaximumNumber, CurrentNumber, PassingGrade, CourseGrade, Hours, Instructor, Description, tmp);
                        WelcomePage.AllCoursesDictionary[CourseName] = newcourse;

                    }
                    else
                    {

                        MessageBox.Show(" This course doesn't exists !");
                    }
                }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AddCourseButton.Visibility = System.Windows.Visibility.Visible;
            EditCourseButton.Visibility = System.Windows.Visibility.Visible;
            AddCourseButton_second.Visibility = System.Windows.Visibility.Hidden;
            CoursePrequestiesComboBox.Visibility = System.Windows.Visibility.Hidden;
            TmpLabel.Visibility = System.Windows.Visibility.Hidden;
        }

        private void EnterCoursePrequesties_Checked(object sender, RoutedEventArgs e)
        {
            AddCourseButton.Visibility = System.Windows.Visibility.Hidden;
            EditCourseButton.Visibility = System.Windows.Visibility.Hidden;
            AddCourseButton_second.Visibility = System.Windows.Visibility.Visible;
            CoursePrequestiesComboBox.Visibility = System.Windows.Visibility.Visible;
            TmpLabel.Visibility = System.Windows.Visibility.Visible;
        }

        private void AddCourseButton_second_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTextBox.Text.Length == 0 || CourseNameTextBox.Text.Length == 0 || MaximumNumberOfStudentsTextBox.Text.Length == 0 || CurrentNumberOfStudentsTextBox.Text.Length == 0 || PassingGradeTextBox.Text.Length == 0 || CourseGradeTextBox.Text.Length == 0 || HoursTextBox.Text.Length == 0 || InstructorTextBox.Text.Length == 0 || DescriptionTextBox.Text.Length == 0)
            {
                MessageBox.Show("Some text box is missing");
            }
            else
            {
                if (CoursePrequestiesComboBox.SelectedIndex==-1)
                {
                    MessageBox.Show("Please select course to be prerequstie or uncheck the check box!");

                }
                else if (CheckNumberOfStudentsTextBoxes() && CheckGradesTextBoxes() && CheckHoursTextBox() && CheckAllTheRemainingTextBoxes())
                {

                    string Code = CodeTextBox.Text;
                    string CourseName = CourseNameTextBox.Text;
                    int MaximumNumber = int.Parse(MaximumNumberOfStudentsTextBox.Text);
                    int CurrentNumber = int.Parse(CurrentNumberOfStudentsTextBox.Text);
                    int PassingGrade = int.Parse(PassingGradeTextBox.Text);
                    int CourseGrade = int.Parse(CourseNameTextBox.Text);
                    int Hours = int.Parse(HoursTextBox.Text);
                    string Instructor = InstructorTextBox.Text;
                    string Description = DescriptionTextBox.Text;
                    List<string> tmp = new List<string>();
                    tmp.Add(CoursePrequestiesComboBox.SelectedItem.ToString());
                    if (WelcomePage.AllCoursesDictionary.ContainsKey(CourseName))
                    {
                        MessageBox.Show("This course already exists ");

                    }
                    else
                    {

                        Course newcourse = new Course(Code, CourseName, MaximumNumber, CurrentNumber, PassingGrade, CourseGrade, Hours, Instructor, Description, tmp);
                        WelcomePage.AllCoursesDictionary[CourseName] = newcourse;
                    }
                }
            }
        }

    }
}
