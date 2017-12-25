using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for EnterStudentGrades.xaml
    /// </summary>
    /// Made By : Hazem Khairy ^_^ 
    public partial class EnterStudentGrades : Window
    {
        public EnterStudentGrades()
        {
            InitializeComponent();

        }
        string SelectedStudent = "";
        List<TextBlock> CoursesNameLabels = new List<TextBlock>();
        List<TextBox> CoursesGradeTextBox = new List<TextBox>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                StudentsComboBox.Items.Add(x.Key+' ' +x.Value.Name);
            }
        }
        Button AddGrades = new Button();
        
        
        
        bool CheckAllTextBoxs()
        {
            // check the format entered in each text box 
            foreach (var x in CoursesGradeTextBox)
            {
                if (x.Text=="")
                {
                    //check if the text box is empty
                    MessageBox.Show("Some text box is empty");
                    return false;
                }
                else if (!ValidMark(x.Text) )
                {
                    //check if the text have some text other than numbers and '.' 
                    MessageBox.Show("each text box should contains numbers only");
                    return false;
                }
            }
            
            return true;
        }
        bool ValidMark(string mark)
        {
            //check if the text have some text other than numbers 
            for (int i = 0 ; i < mark.Length ; i++)
            {
                if ((mark[i]<'0'||mark[i]>'9'))
                {
                    return false;
                }
            }
            return true;
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAllTextBoxs()==true)
            {
                EnterGrades();
            }
        }
        void EnterGrades()
        {
            int PassedCourses = 0;
            List<Course_Prerequsites_WPF.Classes.Course> finishedtmp = new List<Classes.Course>();
            foreach (var x in CoursesGradeTextBox)
            {
                if (WelcomePage.AllCoursesDictionary[x.Tag.ToString()].PassingGrade <= int.Parse(x.Text) && WelcomePage.AllCoursesDictionary[x.Tag.ToString()].CourseGrade>=int.Parse(x.Text)) 
                {
                    // if the student pass this course add this course to his finished courses
                    finishedtmp.Add(WelcomePage.AllCoursesDictionary[x.Tag.ToString()]);
                    PassedCourses++;
                }
                else if (WelcomePage.AllCoursesDictionary[x.Tag.ToString()].CourseGrade < int.Parse(x.Text))
                {
                    //return if the entered grade is greater than the course grade
                    MessageBox.Show("you entered Integer bigger than the course grade at " + x.Tag.ToString() + " Text box ");
                    return ;
                }
            }

            foreach(var x in finishedtmp)
            {
                //add the courses which student passed in to his finished courses    
                WelcomePage.AllStudentsDictionary[SelectedStudent].FinishedCourses.Add(x);
            }
            foreach (var x in WelcomePage.AllStudentsDictionary[SelectedStudent].CoursesInProgress)
            {
                
            // remove the student from the CurrentNumberOfstudent of each course
                WelcomePage.AllCoursesDictionary[x.CourseName].CurrentNumberOfStudents--;
            }
            //remove all in progress courses of the student
            WelcomePage.AllStudentsDictionary[SelectedStudent].CoursesInProgress = new List<Classes.Course>();
            MessageBox.Show("This student passed : " + PassedCourses.ToString() );
        }

        private void StudentsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StudentsComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select some student");
            }
            else
            {
                string[] tosplit = StudentsComboBox.SelectedValue.ToString().Split(' ');
                SelectedStudent = tosplit[0];
                //clear the grid and lists ( in case there were a student before )
                MyGrid.Children.Clear();
                CoursesGradeTextBox.Clear();
                CoursesNameLabels.Clear();
                //check if the student has in progress courses
                if (WelcomePage.AllStudentsDictionary[SelectedStudent].CoursesInProgress.Count == 0)
                {
                    MessageBox.Show("this student have no Current courses in progress");
                    return;
                }
                // create text block control in the top
                int i = 0;
                TextBlock InfoTmp = new TextBlock();
                InfoTmp.Margin = new Thickness(200, 10, 0, 0);
                InfoTmp.Text = "Enter the Grades of Student : " + WelcomePage.AllStudentsDictionary[SelectedStudent].Name;
                MyGrid.Children.Add(InfoTmp);
                foreach (var x in WelcomePage.AllStudentsDictionary[SelectedStudent].CoursesInProgress)
                {
                    // create a text block holding the name of course
                    TextBlock TextBlockTmp = new TextBlock();
                    TextBlockTmp.Text = x.CourseName + " : ";
                    TextBlockTmp.Margin = new Thickness(95, 111 + (i * 50), 0, 0);
                    // creating textbox to enter the grade at in and the tag of it has the course name
                    TextBox TextBoxTmp = new TextBox();
                    TextBoxTmp.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                    TextBoxTmp.Width = 120;
                    TextBoxTmp.Height = 23;
                    TextBoxTmp.ToolTip = "Enter the Grade of " + x.CourseName;
                    TextBoxTmp.Margin = new Thickness(371, 111 + (i * 50), 0, 0);
                    TextBoxTmp.Tag = x.CourseName.ToString();
                    //add the controls to the grid
                    MyGrid.Children.Add(TextBlockTmp);
                    MyGrid.Children.Add(TextBoxTmp);

                    i++;
                    CoursesNameLabels.Add(TextBlockTmp);
                    CoursesGradeTextBox.Add(TextBoxTmp);
                }
                //add Done Button at the end of grid
                AddGrades.Content = "Done";

                AddGrades.Height = 30;
                AddGrades.Width = 100;
                AddGrades.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                AddGrades.VerticalAlignment = System.Windows.VerticalAlignment.Top;
                AddGrades.Margin = new Thickness(250, 111 + (i * 50), 0, 0);
                AddGrades.Click += Done_Click;
                MyGrid.Children.Add(AddGrades);
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentsSettings stud = new StudentsSettings();
            stud.Show();
            this.Close();

            
        }
    }
}
