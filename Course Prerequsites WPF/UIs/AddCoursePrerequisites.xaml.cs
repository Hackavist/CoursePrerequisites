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
    /// Interaction logic for AddCoursePrerequisites.xaml
    /// </summary>
    public partial class AddCoursePrerequisites : Window
    {
        public AddCoursePrerequisites()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            bool check = true;

            Admin ad = new Admin();
           
            string coursename = CourseNameBox.SelectedItem.ToString();
            string prerequisitename = PrerequisiteNameTextBox.Text;
             
          
             if (prerequisitename.Length == 0)
            {
                MessageBox.Show("Please enter the Prerequisite name!!");
            }
            else
            {
                Course obj = new Course();

                obj = obj.ReturnObj(coursename);

                for (int i = 0; i < obj.PreRequiredCourses.Count; i++)
                {
                    if (obj.PreRequiredCourses[i] == prerequisitename)
                    {
                        MessageBox.Show("Prerequisite is Already Exist!!");
                        check = false;

                    }
                }

                if (check == true)
                {
                    ad.AddCoursePrerquisite(coursename, prerequisitename);
                    MessageBox.Show("Prerequisite is Successfully Added");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Add All Courses that exist on combo box
            foreach (var x in WelcomePage.AllCoursesDictionary)
            CourseNameBox.Items.Add(x.Key);
        }
    }
}
