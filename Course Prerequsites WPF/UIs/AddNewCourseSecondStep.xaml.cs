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
using Course_Prerequsites_WPF.Classes;
using Course_Prerequsites_WPF.UIs;
namespace Course_Prerequsites_WPF.UIs
{
    /// <summary>
    /// Interaction logic for AddNewCourseSecondStep.xaml
    /// </summary>
    /// Made By : Hazem Khairy ^_^
    public partial class AddNewCourseSecondStep : Window
    {
        DropShadowEffect shadoweffect;
        public AddNewCourseSecondStep()
        {
            InitializeComponent();
            shadoweffect = new DropShadowEffect
            {
                Direction = 300,
                ShadowDepth = 9
            };
            foreach (var x in WelcomePage.AllCoursesDictionary)
            {
                mylist.Children.Add(CreateCanvasElement(x.Value));
            }
        }
        List<CheckBox> CheckBoxList = new List<CheckBox>();
        Canvas CreateCanvasElement(Course CourseTmp)
        {
            Canvas canvastmp = new Canvas();
            canvastmp.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            canvastmp.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            canvastmp.Margin = new Thickness(5, (15), 0, 10);
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


            canvastmp.Children.Add(checkboxtmp);
            CheckBoxList.Add(checkboxtmp);
            canvastmp.ToolTip = CourseTmp.PutInfoInToolTip();
            return canvastmp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            List<string> tmp = new List<string>();
            foreach (var x in CheckBoxList)
            {
                if (x.IsChecked == true)
                {
                    counter++;
                    tmp.Add(x.Tag.ToString());
                }
            }
            MessageBoxResult result = MessageBox.Show("Are you sure you want to add " + counter + " courses as prerequsites of the new course !", "Confirm", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                foreach (var x in tmp)
                    AddNewCourse.CoursePrerequstiesTmp.Add(x);
                this.Close();
            }
            else
            {
                MessageBox.Show("Reselect the courses you to be the prerequsites or go back");
            }
        }
    }
}
