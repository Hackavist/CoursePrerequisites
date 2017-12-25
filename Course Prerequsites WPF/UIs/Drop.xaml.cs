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

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for Drop.xaml
    /// </summary>
    public partial class Drop : Window
    {
        string selected;
        List<string> ids = new List<string>();
        public Drop()
        {
            InitializeComponent();
            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                comboBoxName.Items.Add(x.Value.Name);
                ids.Add(x.Key);
            }
        }

        private void comboBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxCours.Items.Clear();
            selected = ids[comboBoxName.SelectedIndex];
            foreach (var x in WelcomePage.AllStudentsDictionary[selected].CoursesInProgress)
            {
                comboBoxCours.Items.Add(x.CourseName);
            }

        }

        private void dropButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage.AllStudentsDictionary[selected].CoursesInProgress.Remove(WelcomePage.AllCoursesDictionary[comboBoxCours.SelectedItem.ToString()]);
            MessageBox.Show("You sucessfully dropped "+ comboBoxCours.SelectedItem.ToString());
            //WelcomePage.AllCoursesDictionary[selected].CurrentNumberOfStudents--;
            //HENA YA HAZEM!!
            comboBoxCours.Items.RemoveAt(comboBoxCours.SelectedIndex);
            comboBoxCours.Text ="";
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            CourseSettings cs = new CourseSettings();
           cs.Show();
            this.Close();
        }
    }
}
