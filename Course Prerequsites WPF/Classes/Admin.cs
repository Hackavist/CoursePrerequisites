using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Course_Prerequsites_WPF.Classes;
using Course_Prerequsites_WPF.UIs;

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


        //writing Format:   Name*Password*General Manager (1 or 0)#
        public Dictionary<string, Admin> GetAllAdmins()
        {
            FileStream fs = new FileStream("AllAdminsFile.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] field, record;

            Dictionary<string, Admin> AllAdmins = new Dictionary<string, Admin>();

            while (sr.Peek() != -1)
            {
                record = sr.ReadLine().Split('#');
                //changed split character to %
                for (int i = 0; i < record.Length - 1; i++)
                {
                    field = record[i].Split('%');
                    UserName = field[0];
                    Password = field[1];
                    GeneralManager = Convert.ToInt32(field[2]); // Converted to int 
                    Admin data = new Admin(UserName, Password, GeneralManager);

                    AllAdmins[UserName] = data;
                }
            }

            sr.Close();
            fs.Close();

            return AllAdmins;
        }

        public void AddCoursePrerquisite(string coursename, string prerequisitename)
        {
            WelcomePage.AllCoursesDictionary[coursename].PreRequiredCourses.Add(prerequisitename);
        }

        //writing Format:   Name*Password*General Manager (1 or 0)#

        public void WriteFile()
        {
            if (WelcomePage.AllAdminsDictionary != null)
            {
                FileStream File = new FileStream("AllAdminsFile.txt", FileMode.Append, FileAccess.Write);
                StreamWriter Sw = new StreamWriter(File);

                //writes the data members of each student in the dictionary
                foreach (var admin in WelcomePage.AllAdminsDictionary.Values)
                {
                    Sw.Write(admin.UserName);
                    Sw.Write('%');
                    Sw.Write(admin.Password);
                    Sw.Write('%');
                    Sw.Write(Convert.ToString(admin.GeneralManager));
                    //end of record dilimter
                    Sw.Write('#');
                }
                //closes the stream writer and the file stream 
                Sw.Close();
                File.Close();
            }
            else
            {
                //throws an exceptions that says Unimplmented 
                throw new NotImplementedException();
            }
        }

        public void FileClear()
        {
            File.WriteAllText(@"AllAdminsFile.txt", string.Empty);
        }
    }
}
