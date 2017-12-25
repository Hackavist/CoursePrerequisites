using Course_Prerequsites_WPF.Classes;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for EditCoursePrerequsites.xaml
    /// </summary>
    public partial class EditCoursePrerequsites : Window
    {
        Course selectedcourse;
        DropShadowEffect shadoweffect = new DropShadowEffect
        {
            Direction = 300,
            ShadowDepth = 9
        };
        Dictionary<Course, bool> visited = new Dictionary<Course,bool>();
        public EditCoursePrerequsites()
        {
            InitializeComponent();
            // get the required course
            selectedcourse = EditCourse.SelectedCourse;
            
            //add all courses ( in canvas form ) to the panel
            fillthegrid();
            
            
        }
        void fillthegrid()
        {
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                
                if (dfs(x.Value)==true && x.Value!=selectedcourse)
                {
                    //visited = new Dictionary<Course, bool>();
                mylist.Children.Add(CreateCanvasElement(x.Value));

                }
            }
        }
        bool dfs(Course tocheck)
        {
            if (tocheck.CourseName==selectedcourse.CourseName)
                return false ;
            if (tocheck.PreRequiredCourses.Count == 0)
                return true;

            bool ret = true;
            foreach(var x in tocheck.PreRequiredCourses)
            {
                if (visited.ContainsKey(WelcomePage.AllCoursesDictionary[x]) &&  visited[WelcomePage.AllCoursesDictionary[x]] != true)
                {
                    visited[WelcomePage.AllCoursesDictionary[x]] = true;
                    ret = ret & dfs(WelcomePage.AllCoursesDictionary[x]);
                }
            }
            return ret;
        }

        List<CheckBox> CheckBoxList = new List<CheckBox>();
        Canvas CreateCanvasElement(Course CourseTmp)
        {

            Canvas canvastmp = new Canvas();
            canvastmp.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            canvastmp.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            canvastmp.Margin = new Thickness(5, (10), 0, 10);
            canvastmp.Height = (50);
            canvastmp.Effect = shadoweffect;
            canvastmp.Width = 545;
            canvastmp.Background = System.Windows.SystemColors.ControlBrush;

            TextBlock textblocktmp = new TextBlock();
            textblocktmp.Text = "Course Name : " + CourseTmp.CourseName;
            textblocktmp.FontSize = 20;
            textblocktmp.FontWeight = FontWeights.Bold;
            textblocktmp.Margin = new Thickness(10, 10, 0, 0);
            textblocktmp.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            textblocktmp.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

            // add the text block to the canvas
            canvastmp.Children.Add(textblocktmp);

            CheckBox checkboxtmp = new CheckBox();
            checkboxtmp.Padding = new Thickness(3, -6, 0, 0);
            checkboxtmp.FontSize = 16;
            checkboxtmp.FontWeight = FontWeights.Bold;
            checkboxtmp.Margin = new Thickness(450, 20, 0, 0);
            checkboxtmp.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            checkboxtmp.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            checkboxtmp.Content = "";
            checkboxtmp.FlowDirection = System.Windows.FlowDirection.RightToLeft;
            checkboxtmp.Tag = CourseTmp.CourseName;

            // mark the already prerequsities course
            foreach (var x in selectedcourse.PreRequiredCourses)
            {
                if (x == CourseTmp.CourseName)
                {
                    checkboxtmp.IsChecked = true;
                }
            }
            // add the checkbox to list to easily access it later
            CheckBoxList.Add(checkboxtmp);

            // add the check box to the canvas
            canvastmp.Children.Add(checkboxtmp);
            //add tool tip to the canvas
            canvastmp.ToolTip = CourseTmp.PutInfoInToolTip();
            return canvastmp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectedcourse.PreRequiredCourses = new List<string>();
            foreach (var x in CheckBoxList)
            {
                if (x.IsChecked==true)
                {
                    selectedcourse.PreRequiredCourses.Add(x.Tag.ToString());
                }
            }
            EditCourse.SelectedCourse = selectedcourse;
            this.Close();
        }
    }
}
