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
using Course_Prerequsites_WPF;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for TestingForm.xaml
    /// </summary>
    public partial class TestingForm : Window
    {
        public TestingForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Course_Prerequsites_WPF.Classes.Course> Test = new List<Classes.Course>();
            Test = AllCourses();
        }
    }
}
