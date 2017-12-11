using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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

            //dictionary of all courses
            AllCoursesObj = MainWindow.AllCoursesDictionary ;

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

        public void Branch_Expanded(object sender, RoutedEventArgs e )
        {
            //parces the sender object into a mai
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

            //Reveses the list to out the prequisists in the correct order 
            cour.PreRequiredCourses.Reverse();
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

        private void AllCourses_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //if (Branch_Expanded==true)
            //{
                
            //}
            //MessageBox.Show("Test suc");
        }
    }
}
