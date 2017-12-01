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
    /// Interaction logic for AspecificCourse.xaml
    /// </summary>
    public partial class AspecificCourse : Window
    {
        public AspecificCourse()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course cour = new Course();
            cour=cour.ReturnObj("Math3");

            CourseName.Text = cour.CourseName;
            Code.Content = cour.Code;
            MaximumNumberOfStudents.Content = cour.MaximumNumberOfStudents;
            CurrentNumberOfStudents.Content = cour.CurrentNumberOfStudents;
            PassingGrade.Content = cour.PassingGrade;
            CourseGrade.Content = cour.CourseGrade;
            Hours.Content = cour.Hours;
            Instructor.Content = cour.Instructor;
            par.Text = cour.Description;
        }
    }
}
