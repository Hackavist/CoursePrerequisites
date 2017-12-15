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
    public class StackViewModel
    {
        public ObservableCollection<Elements> FinishedItem { get; private set; }
        public ObservableCollection<Elements> InProgressItem { get; private set; }

        public StackViewModel()
        {
            FinishedItem = new ObservableCollection<Elements>();

            foreach (var item in WelcomePage.AllStudentsDictionary["Mohsen"].FinishedCourses)
            {
                var obj = new Elements();
                obj.Category = item.CourseName;
                obj.Number = item.Hours;
                FinishedItem.Add(obj);
            }

            InProgressItem = new ObservableCollection<Elements>();
            foreach (var item in WelcomePage.AllStudentsDictionary["Mohsen"].CoursesInProgress)
            {
                var obj = new Elements();
                obj.Category = item.CourseName;
                obj.Number = item.Hours;
                InProgressItem.Add(obj);
            }

        }

        public static string SelectedText = "";
        public static string SelectedColor = "";

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
