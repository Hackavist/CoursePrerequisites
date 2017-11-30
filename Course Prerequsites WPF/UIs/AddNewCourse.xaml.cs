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
        }

        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTextBox.Text.Length==0 ||  CourseNameTextBox.Text.Length==0 || MaximumNumberOfStudentsTextBox.Text.Length==0 || CurrentNumberOfStudentsTextBox.Text.Length==0 || PassingGradeTextBox.Text.Length==0 || CourseGradeTextBox.Text.Length==0 || HoursTextBox.Text.Length==0 || InstructorTextBox.Text.Length==0 || DescriptionTextBox.Text.Length==0 )
            {
                MessageBox.Show("Some text box is missing");
            }
            else
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
                List <string > tmp =new List <string>() ;
                Course x = new Course();
                Dictionary<string,Course> di =  x.GetAllCourses();
                if (di.ContainsKey(CourseName))
                {
                    MessageBox.Show("This course already exists ");

                }
                else
                {

                Course newcourse = new Course(Code, CourseName, MaximumNumber, CurrentNumber, PassingGrade, CourseGrade, Hours, Instructor, Description, tmp);
                di[CourseName] = newcourse;
                }
            }
        }
    }
}
