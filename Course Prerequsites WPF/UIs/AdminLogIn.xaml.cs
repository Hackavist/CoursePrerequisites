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
using System.IO;

namespace Course_Prerequsites_WPF.UIs

{
    /// <summary>
    /// Interaction logic for AdminLogIn.xaml
    /// </summary>
    public partial class AdminLogIn : Window
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void Username_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
        private void LogIn_txt_Click(object sender, RoutedEventArgs e)
        {
            
            if(string.IsNullOrEmpty(Username_txt.Text) || string.IsNullOrEmpty(Password_txt.Password))
            {
                MessageBox.Show("Missing data");
            }

            else
            {

               string name = Username_txt.Text;
               string password = Password_txt.Password;

               Admin ad = new Admin();

               List < Admin > check = ad.GetAdminData();
               // Dictionary < string, Admin> dic = new Dictionary<string, Admin>();
                for (int i = 0; i < check.Capacity; i++)
                {
                    if (check[i].UserName==name && check[i].Password==password)
                    {
                        
                        ViewStudentOrCourse v = new ViewStudentOrCourse();
                        v.Show();

                        this.Close();

                        break;

                    }
                }
                
                    MessageBox.Show("Wrong Username or Password");
                


            }

        }

        private void Username_txt_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
