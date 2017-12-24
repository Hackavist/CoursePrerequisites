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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
            StudYear.Items.Add("1st year");

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{



        //    //if (string.IsNullOrEmpty(StudName.Text.Trim()) || string.IsNullOrEmpty(StudID.Text.Trim()) || string.IsNullOrEmpty(StudPassword.Text.Trim()) || StudYear.SelectedIndex == -1)
        //    //{
        //    //    MessageBox.Show("Please Enter Missing Data");
        //    //}
        //    //else if (WelcomePage.ThereIsNoDelimiter(StudName.Text.Trim()) == false || WelcomePage.ThereIsNoDelimiter(StudID.Text.Trim()) == false || WelcomePage.ThereIsNoDelimiter(StudPassword.Text.Trim()) == false)
        //    //{
        //    //    MessageBox.Show("Please Don't Use special characters: (% , # , *) ");
        //    //}
        //    //else if (WelcomePage.IsNotAlphabet(StudName.Text.Trim()) == true)
        //    //{
        //    //    MessageBox.Show("Please Enter Correct Name");
        //    //}
        //    //else if(WelcomePage.NoSpace(StudPassword.Text.Trim())==false || WelcomePage.NoSpace(StudID.Text.Trim())==false)
        //    //{
        //    //    MessageBox.Show("ID and Password Must Not Contain Spaces");
        //    //}

        //    //else
        //    //{
        //    //    string name = StudName.Text.Trim();
        //    //    string id = StudID.Text.Trim();
        //    //    string pass = StudPassword.Text.Trim();
        //    //    string year = StudYear.SelectedItem.ToString();

        //    //    Student s = new Student(id, name, pass, year);

        //    //    if (WelcomePage.AllStudentsDictionary.ContainsKey(id))
        //    //    {
        //    //        MessageBox.Show("this ID already exist");

        //    //    }
        //    //    else
        //    //    {

        //    //        WelcomePage.AllStudentsDictionary[id]=s;
        //    //        MessageBox.Show("Student Added");

        //    //        StudName.Clear();
        //    //        StudID.Clear();
        //    //        StudPassword.Clear();
        //    //        StudYear.SelectedIndex = -1;

        //    //        /* if(StudYear.SelectedValue.ToString()!= "1st year")
        //    //        {
        //    //            FinishedCourses.Visibility = Visibility.Visible;
        //    //        }
        //    //        */

        //    //        CheckBox.Visibility = Visibility.Visible;


        //    //    }
        //    //}

        //}


        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (string.IsNullOrEmpty(StudName.Text.Trim()) || string.IsNullOrEmpty(StudID.Text.Trim()) || string.IsNullOrEmpty(StudPassword.Text.Trim()) || StudYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Missing Data");
            }
            else if (WelcomePage.ThereIsNoDelimiter(StudName.Text.Trim()) == false || WelcomePage.ThereIsNoDelimiter(StudID.Text.Trim()) == false || WelcomePage.ThereIsNoDelimiter(StudPassword.Text.Trim()) == false)
            {
                MessageBox.Show("Please Don't Use special characters: (% , # , *) ");
            }
            else if (WelcomePage.IsNotAlphabet(StudName.Text.Trim()) == true)
            {
                MessageBox.Show("Please Enter Correct Name");
            }
            else if (WelcomePage.NoSpace(StudPassword.Text.Trim()) == false || WelcomePage.NoSpace(StudID.Text.Trim()) == false)
            {
                MessageBox.Show("ID and Password Must Not Contain Spaces");
            }
            else
            {
                string name = StudName.Text.Trim();
                string id = StudID.Text.Trim();
                string pass = StudPassword.Text.Trim();
                string year = StudYear.SelectedItem.ToString();

                Student s = new Student(id, name, pass, year);

                if (WelcomePage.AllStudentsDictionary.ContainsKey(id))
                {
                    MessageBox.Show("this ID already exist");
                }
                else
                {
                    WelcomePage.AllStudentsDictionary[id] = s;
                    MessageBox.Show("Student Added");

                    StudName.Clear();
                    StudID.Clear();
                    StudPassword.Clear();
                    StudYear.SelectedIndex = -1;
                }
            }

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            StudentsSettings st = new StudentsSettings();
            st.Show();
            this.Close();
        }
    }
}
