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
    /// Interaction logic for RemoveAdmin.xaml
    /// </summary>
    public partial class RemoveAdmin : Window
    {
        public RemoveAdmin()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            AdminSettings ad = new AdminSettings();
            ad.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in WelcomePage.AllAdminsDictionary.Values)
            {
                if ((item.GeneralManager != 1))
                {
                    AdminsCombo.Items.Add(item.UserName);
                }

            }
        }

        private void RemoveBTN_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Remove admin?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                WelcomePage.AllAdminsDictionary.Remove(AdminsCombo.SelectedValue.ToString());
                MessageBox.Show("Admin has been removed.");
            }
        }
    }
}
