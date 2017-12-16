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
            StudYear.Items.Add("2nd year");
            StudYear.Items.Add("3rd year");
            StudYear.Items.Add("4th year");
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(  string.IsNullOrEmpty(StudName.Text) || string.IsNullOrEmpty(StudID.Text) || string.IsNullOrEmpty(StudPassword.Text) || string.IsNullOrEmpty(StudYear.Text) )
            {
                MessageBox.Show("Please Enter Missing Data");
            }
            else
            {
                string name = StudName.Text;
                string id = StudID.Text;
                string pass = StudPassword.Text;
                string year = StudYear.SelectedItem.ToString();
                
                Student s = new Student(id, name, pass, year);

                if (WelcomePage.AllStudentsDictionary.ContainsKey(id))
                {
                    MessageBox.Show("this ID already exist");

                }
                else
                {
                    WelcomePage.AllStudentsDictionary[id]=s;
                    MessageBox.Show("Student Added");

                    StudName.Clear();
                    StudID.Clear();
                    StudPassword.Clear();
                    StudYear.SelectedIndex = -1;
                   
                }
            }
        }

       
    }
}
