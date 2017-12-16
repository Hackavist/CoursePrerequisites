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
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                if ((s.CheckPrequired(x.Value.CourseName) == true) && (x.Value.CurrentNumberOfStudents < x.Value.MaximumNumberOfStudents))
                {
                    AvailableCourseBox.Items.Add(x.Key);
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            Course c =WelcomePage.Course.ReturnObj(AvailableCourseBox.SelectionBoxItem.ToString());
            WelcomePage.AllStudentsDictionary[WelcomePage.StudentId].CoursesInProgress.Add(c);
            WelcomePage.AllCoursesDictionary[AvailableCourseBox.SelectionBoxItem.ToString()].CurrentNumberOfStudents++;
            MessageBox.Show("You are now regist to this Course");
        }
    }
}

