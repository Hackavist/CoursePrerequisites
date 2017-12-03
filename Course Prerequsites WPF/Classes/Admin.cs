using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course_Prerequsites_WPF.Classes
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool GeneralManager { get; set; }

        public Admin()
        {
            UserName = "";
            Password = "";
            GeneralManager = false;
        }
        public Admin(string Name, string Pass, bool Flag)
        {
            UserName = Name;
            Password = Pass;
            GeneralManager = Flag;
        }

        public List<Admin> GetAdminData()
        {
            FileStream fs = new FileStream("AdminData.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string[] field , record;
            

            while(sr.Peek()!=-1)
            {
                record = sr.ReadLine().Split('#');

                for(int i=0;i<record.Length;i++)
                {
                    field = record[i].Split('*');
                    UserName = field[0];
                    Password = field[1];
                    GeneralManager = bool.Parse(field[2]);
                }

            }

            Admin data = new Admin(UserName, Password,GeneralManager);

            List<Admin> ListOfAdminData = new List<Admin>();
            ListOfAdminData.Add(data);

            sr.Close();
            
            return ListOfAdminData;
            

        }
        
       
    }
}
