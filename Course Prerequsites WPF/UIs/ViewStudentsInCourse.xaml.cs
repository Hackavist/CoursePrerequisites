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
    /// Interaction logic for ViewStudentsInCourse.xaml
    /// </summary>
    public partial class ViewStudentsInCourse : Window
    {
        public ViewStudentsInCourse()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(SearchCourseName.Text) )
            {
                MessageBox.Show("Please Enter Course Name");
            }
            else
            {

                //string courseName = SearchCourseName.Text;
                //Student s = new Student();
                //List<Student> stud = s.GetPersonalInfo(); //waiting for team student

                //for(int i=0 ; i<stud.Capacity ; i++)
                //{
                //    stud[i].CoursesInProgress
                //        // if course name == name in textbox
                //        //display student's name

                //}



            }
        }
    }
}
