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
using Course_Prerequsites_WPF.Classes;
using Course_Prerequsites_WPF.ViewModels;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for AllCoursesChart.xaml
    /// </summary>
    public partial class AllCoursesChart : Window
    {
        public AllCoursesChart()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void CoursesChart_Click(object sender, MouseButtonEventArgs e)
        {
            AspecificCourse asd = new AspecificCourse(ChartViewModel.SelectedText);
            asd.Show();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentControls stud = new StudentControls();
            stud.Show();
            this.Close();
        }
    }
}
