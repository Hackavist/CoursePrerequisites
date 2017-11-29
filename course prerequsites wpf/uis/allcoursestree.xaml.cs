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
using Course_Prerequsites_WPF.Classes;

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

        //tree Parents Appear On Load
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            // get every local drive on the machine 
            foreach(var item in Directory.GetLogicalDrives() )
            {
                //create a tree view item for it 
                var branch = new TreeViewItem();

                //set the header 
                branch.Header = item;

                //set the path 
                branch.Tag = item;

                //listen out for items being expanded 

                branch.Expanded += Branch_Expanded;

                AllCourses.Items.Add(branch);
                branch.Items.Add(null);
            }*/

            Dictionary<string,Course> AllCoursesObj = new Dictionary<string, Course>();
            Course cour = new Course();
            AllCoursesObj = cour.GetAllCourses();

            foreach (var course in AllCoursesObj)
            {
                var branch = new TreeViewItem();

                branch.Header = course.Value.CourseName;

                AllCourses.Items.Add(branch);

                foreach (var pre in course.Value.PreRequiredCourses)
                {
                    var leaf = new TreeViewItem();
                    var l = course.Value.ReturnObj(pre);
                    branch.Items.Add(l);
                }

            }
        }

        private void Branch_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;
            //checks if the containing are dummy data  
            if (item.Items.Count != 1 || item.Items[0] != null)
            {
                return;
            }

            //Cleans Dummy Data 
            item.Items.Clear();


        }
    }
}
