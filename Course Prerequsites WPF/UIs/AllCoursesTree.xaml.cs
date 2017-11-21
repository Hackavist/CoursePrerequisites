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
using System.IO;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for AllCoursesTree.xaml
    /// </summary>
    public partial class AllCoursesTree : Window
    {
        public AllCoursesTree()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in Directory.GetLogicalDrives() )
            {
                var branch = new TreeViewItem();
                branch.Header = item;
                branch.Tag = item;

                AllCourses.Items.Add(branch);
                branch.Items.Add(null);
            }
        }
    }
}
