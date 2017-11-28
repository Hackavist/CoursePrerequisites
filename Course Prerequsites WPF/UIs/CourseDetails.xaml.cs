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
    /// Interaction logic for CourseDetails.xaml
    /// </summary>
    public partial class CourseDetails : Window
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           Course obj = new Course();
            obj = obj.ObjectDetails("Math3");
            CourseTitle.Text = obj.CourseName;
            CourseInstructor.Text = obj.Instructor;
            CourseHours.Text = obj.Hours;


        }

        private void LeadToWindow2_Click(object sender, RoutedEventArgs e)
        {
            CourseDetails.cont
        }
    }
}
