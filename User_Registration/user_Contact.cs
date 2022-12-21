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
            string lastnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexlast = new Regex(lastnameregex);
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
        public string Email(string email)
        {
            var emailregex = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regexlast = new Regex(emailregex);
            if (regexlast.IsMatch(email))
            {
                Console.WriteLine(email + " Email is valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " Email is invalid");
                return null;
            }
        }
        public string Number(string number)
        {
            string Numberregex = "^91 [6-9]{1}[0-9]{9}$";
            Regex regexlast = new Regex(Numberregex);
            if (regexlast.IsMatch(number))
            {
                Console.WriteLine(number + " Number is valid");
                return number;
            }
            else
            {
                Console.WriteLine(number + " Number is invalid");
                return null;
            }
        }
    }
}
