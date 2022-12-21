using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Registration
{
    internal class user_Contact
    {
        public string Firstname(string name) 
        {
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(name))
            {
                Console.WriteLine("Name is valid");
                return name;
            }
            else
            {
                Console.WriteLine("Name is invalid");
                return null;
            }
        }
    }
}
