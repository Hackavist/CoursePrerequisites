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

namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for AspecificCourse.xaml
    /// </summary>
    public partial class AspecificCourse : Window
    {
        public List<Elements> Pre = new List<Elements>();
        public static string CourseNa;

        public AspecificCourse(string str)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            CourseNa = str;
            if (WelcomePage.AllCoursesDictionary[CourseNa].PreRequiredCourses.Count==0)
            {
                Elements ele = new Elements()
                {
                    Category = "This Course has no Prerequisits",
                    Number = 0
                };
                Prerequsites.Items.Add(ele);
            }
            else
            {
                for (int i = 0; i < WelcomePage.AllCoursesDictionary[CourseNa].PreRequiredCourses.Count; i++)
                {
                    Elements ele = new Elements();
                    ele.Category = WelcomePage.AllCoursesDictionary[CourseNa].PreRequiredCourses[i];
                    ele.Number = i;
                    Prerequsites.Items.Add(ele);
                }
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course cour = new Course();
            cour = cour.ReturnObj(CourseNa);

            CourseName.Text = cour.CourseName;
            Code.Text = cour.Code;
            MaximumNumberOfStudents.Text = Convert.ToString(cour.MaximumNumberOfStudents);
            CurrentNumberOfStudents.Text = Convert.ToString(cour.CurrentNumberOfStudents);
            PassingGrade.Text = Convert.ToString(cour.PassingGrade);
            CourseGrade.Text = Convert.ToString(cour.CourseGrade);
            Hours.Text = Convert.ToString(cour.Hours);
            Instructor.Text = cour.Instructor;
            Description.Text = cour.Description;
        }

        private void ReturnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    public class TempletSelector : DataTemplateSelector
    {
        public DataTemplate NormalItem { get; set; }
        public DataTemplate LastItem { get; set; }
        public DataTemplate Empty { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
            {
                return null;
            }
            else
            {
                FrameworkElement frame = container as FrameworkElement;

                string name = ((Elements)item).Category;
                int order = ((Elements)item).Number;

                if (WelcomePage.AllCoursesDictionary[AspecificCourse.CourseNa].PreRequiredCourses.Count == 0)
                {
                    Empty = frame.FindResource("Empty") as DataTemplate;
                    return Empty;
                }
                else if (order < WelcomePage.AllCoursesDictionary[AspecificCourse.CourseNa].PreRequiredCourses.Count - 1)
                {
                    NormalItem = frame.FindResource("NormalItem") as DataTemplate;
                    return NormalItem;
                }
                else
                {
                    LastItem = frame.FindResource("LastItem") as DataTemplate;
                    return LastItem;
                }
            }
        }
    }
}
