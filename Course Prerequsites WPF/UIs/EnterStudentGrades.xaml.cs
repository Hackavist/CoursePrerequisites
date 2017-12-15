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
    /// Interaction logic for EnterStudentGrades.xaml
    /// </summary>
    public partial class EnterStudentGrades : Window
    {
        public EnterStudentGrades()
        {
            InitializeComponent();
        }
        List<Label> CoursesNameLabels = new List<Label>();
        List<TextBox> CoursesGradeTextBox = new List<TextBox>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var x in WelcomePage.AllStudentsDictionary)
            {
                StudentsComboBox.Items.Add(x.Key);
            }
        }

        private void SelectStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsComboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please select some student");
            }
            else
            {
                int i = 0 ;
                var window = new Window();
                    var stackPanel = new StackPanel { Orientation = Orientation.Vertical };
                string SelectedStudent = StudentsComboBox.SelectedValue.ToString();
                MyGrid.Children.Clear();
                
                foreach (var x in WelcomePage.AllStudentsDictionary[SelectedStudent].CoursesInProgress)
                {
                    
                    MessageBox.Show(x.CourseName);
                    Label LabelTmp = new Label();
                    LabelTmp.Content = x.CourseName + " : ";
                    LabelTmp.Name = "Course" + x.CourseName;
                    LabelTmp.Margin = new Thickness(95,111+(i*50) ,0,0);
                    TextBox TextBoxTmp = new TextBox();
                    TextBoxTmp.Width = 120;
                    TextBoxTmp.Height = 23;
                    TextBoxTmp.Margin = new Thickness(371, 111 + (i * 50), 0, 0);
                    MessageBox.Show(TextBoxTmp.Margin.Top.ToString());
                    TextBoxTmp.Name = "GradeOf" + x.CourseName;

                    //stackPanel.Children.Add(LabelTmp);
                    //stackPanel.RegisterName(LabelTmp.Name, LabelTmp);
                    MyGrid.Children.Add(LabelTmp);

                    MyGrid.Children.Add(TextBoxTmp);
                    //stackPanel.RegisterName(TextBoxTmp.Name, TextBoxTmp);

                    i++;
                    CoursesNameLabels.Add(LabelTmp);
                    CoursesGradeTextBox.Add(TextBoxTmp);
                }
            }
        }
    }
}
