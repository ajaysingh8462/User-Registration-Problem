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
                Console.WriteLine(name+ " FirstName is valid");
                return name;
            }
            else
            {
                Console.WriteLine(name+ " FirstName is invalid");
                return null;
            }
        }
        public string Lastname(string name)
        {
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexlast = new Regex(firstnameregex);
            if (regexlast.IsMatch(name))
            {
                Console.WriteLine(name+ " LastName is valid");
                return name;
            }
            else
            {
                Console.WriteLine(name+ " LastName is invalid");
                return null;
            }
        }
    }
}
