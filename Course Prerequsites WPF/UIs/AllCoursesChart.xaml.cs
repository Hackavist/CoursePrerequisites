using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AllCoursesChart.xaml
    /// </summary>
    public partial class AllCoursesChart : Window
    {
        public AllCoursesChart()
        {
            InitializeComponent();
        }

        private void CoursesChart_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AspecificCourse asd = new AspecificCourse(ChartViewModel.SelectedText);
            asd.Show();
        }
    }

    // class which represent a data point in the chart
    public class Elements
    {
        public string Category { get; set; }

        public int Number { get; set; }
    }
    public class ChartViewModel
    {
        public ObservableCollection<Elements> ChartItem { get; private set; }

        public ChartViewModel()
        {
            ChartItem = new ObservableCollection<Elements>();
            foreach (var item in WelcomePage.AllCoursesDictionary.Keys)
            {
                var obj = new Elements();
                obj.Category = item;
                obj.Number = 100 / WelcomePage.AllCoursesDictionary.Count;
                ChartItem.Add(obj);
            }
            //PieChartItem.Add(new TestClass() { Category = "Globalization", Number = 55 });
        }

        public static string SelectedText = "";

        public Elements selectedItem = null;
        public Elements SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;
                SelectedText = selectedItem.Category;
            }
        }
    }

}
