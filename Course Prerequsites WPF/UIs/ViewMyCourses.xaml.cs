using Course_Prerequsites_WPF.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Course_Prerequsites_WPF.ViewModels;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for ViewMyCourses.xaml
    /// </summary>
    public partial class ViewMyCourses : Window
    {
        public ViewMyCourses()
        {
            InitializeComponent();
        }

        private void CoursesChart_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Course cour = WelcomePage.Course.ReturnObj(StackViewModel.SelectedText);
            CourseCode.Text = cour.Code;
            PassingGrade.Text = Convert.ToString(cour.PassingGrade);
            Instuctor.Text = cour.Instructor;
            Description.Text = cour.Description;
            
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentControls stud = new StudentControls();
            stud.Show();
            this.Close();
        }
    }
}
