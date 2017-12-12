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
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Window
    {
        // Get All Courses Dictionary
        public static Course Course = new Course();
        public static Dictionary<string, Course> AllCoursesDictionary = Course.GetAllCourses();

        //Get All Students Dictionary 
        public static Student Student = new Student();
        public static Dictionary<string, Student> AllStudentsDictionary = Student.GetAllStudents();

        //Get All Admins Dictionary 
        public static Admin Admin = new Admin();
        public static Dictionary<string, Admin> AllAdminsDictionary = Admin.GetAllAdmins();

        public WelcomePage()
        {
            InitializeComponent();
        }
    }
}
