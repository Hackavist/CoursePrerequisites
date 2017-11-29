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
            //returns a dictionary full of all courses 
            Dictionary<string, Course> AllCoursesObj = new Dictionary<string, Course>();
            Course cour = new Course();
            //dictionary of all courses
            AllCoursesObj = cour.GetAllCourses();

            //for each course in the dictionary create and  add a tree view item 
            foreach (var course in AllCoursesObj)
            {
                var branch = new TreeViewItem(); // new treeview item 

                branch.Header = course.Value.CourseName; // sets the text header of the tree view item to the course Name

                branch.HeaderStringFormat = course.Value.CourseName;

                branch.Items.Add(null); // addes a node to the tree 

                branch.Expanded += Branch_Expanded; // what happens when the tree is expanded 

                AllCourses.Items.Add(branch); // addes the branch to the parent 

            }
        }

        private void Branch_Expanded(object sender, RoutedEventArgs e)
        {
            var x = (TreeViewItem)sender;

            // check if there is a null 

            if (x.Items.Count != 1 || x.Items[0] != null)
            {
                return;
            }

            //cleans the nulls  
            x.Items.Clear();

            //extracts the name of the subject from the sender 
            string name = x.HeaderStringFormat;

            // creates an object of the given name 
            Course cour = new Course();
            cour= cour.ReturnObj(name);

            // loops on the list of prequesists  
            foreach (var pre in cour.PreRequiredCourses)
            {
                // creates a new sub element of the parent 
                var subitem = new TreeViewItem();
                //sets the text of the sub element to the text of the prequisists  
                subitem.Header = pre;
                //addes the sub item to parent 
                x.Items.Add(subitem);

            }
        }
    }
}
