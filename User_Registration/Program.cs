using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Registration
{
    class program
    {
        public static void Main(string[] args)
        {
            user_Contact firstn= new user_Contact();
            firstn.Firstname("Ajay");
            firstn.Firstname("ajay");

        }
    }
}