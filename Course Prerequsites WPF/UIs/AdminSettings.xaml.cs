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
    /// Interaction logic for AdminSettings.xaml
    /// </summary>
    public partial class AdminSettings : Window
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void AddAdmin_Click(object sender, RoutedEventArgs e)
        {
            Add_Admin addAdmin = new Add_Admin();
            addAdmin.Show();
            this.Close();
        }

        private void RemoveAdmin_Click(object sender, RoutedEventArgs e)
        {
            RemoveAdmin ad = new UIs.RemoveAdmin();
            ad.Show();
            this.Close();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            ViewStudentOrCourse ad = new ViewStudentOrCourse();
            ad.Show();
            this.Close();
        }
    }
}
