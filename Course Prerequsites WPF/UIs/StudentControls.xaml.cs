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
using Course_Prerequsites_WPF.UIs;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for StudentControls.xaml
    /// </summary>
    public partial class StudentControls : Window
    {
        public StudentControls()
        {
            InitializeComponent();
        }

        private void editmydatabutton_Click(object sender, RoutedEventArgs e)
        {
            EditMyData myData = new EditMyData();
            myData.Show();
            this.Close();
        }

        private void registerbutton_Click(object sender, RoutedEventArgs e)
        {
            RegisterToNewCouse registerTo = new RegisterToNewCouse();
            registerTo.Show();
            this.Close();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage.StudentLogedIn = false;
            WelcomePage.StudentId = "";
            WelcomePage.StudentPassword = "";
            WelcomePage wel = new WelcomePage();
            wel.Show();
            this.Close();
        }

        private void viewallavailablecoursesbutton_Click(object sender, RoutedEventArgs e)
        {
            AllCoursesChart chart = new AllCoursesChart();
            chart.Show();
            this.Close();
        }

        private void viewmycoursesbutton_Click(object sender, RoutedEventArgs e)
        {
            ViewMyCourses viewmy = new ViewMyCourses();
            viewmy.Show();
            this.Close();

        }
    }
}
