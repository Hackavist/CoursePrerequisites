using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Course_Prerequsites_WPF.Classes;

namespace Course_Prerequsites_WPF.Classes
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int GeneralManager { get; set; } // changed property to int 

        public Admin()
        {
            UserName = "";
            Password = "";
            GeneralManager = 0;
        }

        public Admin(string Name, string Pass, int Flag)// changed to int 
        {
            UserName = Name;
            Password = Pass;
            GeneralManager = Flag; // changed into int 
        }

        public Dictionary<string, Admin> GetAllAdmins()
        {
            FileStream fs = new FileStream("AdminData.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] field, record;


            while (sr.Peek() != -1)
            {
                record = sr.ReadLine().Split('#');

                for (int i = 0; i < record.Length - 1; i++)
                {
                    field = record[i].Split('*');
                    UserName = field[0];
                    Password = field[1];
                    GeneralManager = Convert.ToInt32(field[2]); // Converted to int 

                }
            }
                    Admin data = new Admin(UserName, Password, GeneralManager);

                    Dictionary<string, Admin> AllAdmins = new Dictionary<string, Admin>();
                    AllAdmins[UserName] = data;
            sr.Close();
            fs.Close();

            return AllAdmins;
        }

        public void AddCoursePrerquisite(string coursename, string prerequisitename)
        {
            MainWindow.AllCoursesDictionary[coursename].PreRequiredCourses.Add(prerequisitename);
        }
    }
}
