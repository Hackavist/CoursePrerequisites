using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Prerequsites_WPF.Classes
{
    class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool GeneralManager { get; set; }
        
        Admin()
        {
            UserName = "";
            Password = "";
            GeneralManager = false;
        }
        Admin(string Name , string Pass , bool Flag)
        {
            UserName = Name;
            Password = Pass;
            GeneralManager = Flag;
        }

    }
}
