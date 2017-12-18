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

        //check student login 
        public static bool StudentLogedIn;
        public static string StudentId;
        public static string StudentPassword;

        //check admin login 
        public static bool AdminLogedIn;
        public static string AdminUserName;
        public static string AdminPassword;
        
        public static bool ThereIsNoDelimiter(string TextToCheck)
        {
            //check if delimiter exists in the string
            for ( int i = 0 ; i < TextToCheck.Length ; i++)
            {
                if (TextToCheck[i] == '#' || TextToCheck[i] == '%' || TextToCheck[i] == '*')
                    return false;
            }
            return true;
        }
        public static bool IsNumber(string TextToCheck)
        {
            //check if the text have some text other than numbers 
            for (int i = 0; i < TextToCheck.Length; i++)
            {
                if ((TextToCheck[i] < '0' || TextToCheck[i] > '9'))
                {
                    return false;
                }
            }
            return true;
        }

        
        public WelcomePage()
        {
            InitializeComponent();
           
        }
    }
}
