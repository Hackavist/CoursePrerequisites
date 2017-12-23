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

        private void StudentSettings_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void editmydatabutton_Click(object sender, RoutedEventArgs e)
        {
            EditMyData myData = new EditMyData();
            myData.Show();
            this.Hide();
            this.Close();
        }

        private void registerbutton_Click(object sender, RoutedEventArgs e)
        {
            RegisterToNewCouse registerTo = new RegisterToNewCouse();
            registerTo.Show();
            this.Hide();
            this.Close();
        }

        private void dropacoursebutton_Click(object sender, RoutedEventArgs e)
        {
            Drop drp = new Drop();
            drp.Show();
            this.Hide();
            this.Close();
        }
    }
}
