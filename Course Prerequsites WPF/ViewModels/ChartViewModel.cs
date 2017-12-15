using Course_Prerequsites_WPF.Classes;
using Course_Prerequsites_WPF.UIs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Prerequsites_WPF.ViewModels
{
    public class ChartViewModel
    {
        public ObservableCollection<Elements> ChartItem { get; private set; }

        public ChartViewModel()
        {
            ChartItem = new ObservableCollection<Elements>();
            foreach (var item in WelcomePage.AllCoursesDictionary)
            {
                var obj = new Elements();
                obj.Category = item.Key;
                obj.Number = item.Value.Hours;
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
