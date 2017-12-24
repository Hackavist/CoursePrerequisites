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
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                CourseNames.Items.Add(x.Value.CourseName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudNames.Items.Clear();


            if (CourseNames.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Course Name");
            }
            else
            {
                string name = CourseNames.SelectedItem.ToString();
                Admin ad = new Admin();

                List<string> displayNames = ad.ViewAllStudentsInACourse(name);
                displayNames.Sort();

                if (WelcomePage.AllCoursesDictionary.ContainsKey(name))
                {
                    if (displayNames.Count == 0)
                    {
                        MessageBox.Show("No Students Registered");
                    }
                    else
                    {
                        foreach (var x in displayNames)
                            StudNames.Items.Add(x);
                    }
                }
                else
                {
                    MessageBox.Show("Course Doesn't Exist");
                }
            }
            CourseNames.SelectedIndex = -1;
            // StudNames.SelectedIndex = -1;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            CourseSettings cour = new CourseSettings();
            cour.Show();
            this.Close();
        }
    }
}

