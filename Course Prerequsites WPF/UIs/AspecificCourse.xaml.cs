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
        string CourseNa;
        public AspecificCourse( string str)
        {
            InitializeComponent();
            CourseNa = str;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course cour = new Course();
           
            cour = cour.ReturnObj(CourseNa);
            CourseName.Text = cour.CourseName;
            Code.Content = cour.Code;
            MaximumNumberOfStudents.Content = Convert.ToString(cour.MaximumNumberOfStudents);
            CurrentNumberOfStudents.Content = Convert.ToString(cour.CurrentNumberOfStudents);
            PassingGrade.Content = Convert.ToString(cour.PassingGrade);
            CourseGrade.Content = Convert.ToString(cour.CourseGrade);
            Hours.Content = Convert.ToString(cour.Hours);
            Instructor.Content = cour.Instructor;
            Description.Text = cour.Description;
        }

        private void ReturnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
      
    }
}
