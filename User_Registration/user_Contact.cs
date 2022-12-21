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
        public string Firstname() 
        {
            Console.WriteLine("Enter Firstname Must be incude First character as cap");
            string name = Console.ReadLine();
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
        public string Lastname()
        {
            Console.WriteLine("Enter Lastname Must be incude First character as cap");
            string name = Console.ReadLine();
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
        public string Email()
        {
            Console.WriteLine("Enter Email ");
            string email = Console.ReadLine();
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
        public string Number()
        {
            Console.WriteLine("Enter Phonenumber eg- 91 9855515254 ");
            string number = Console.ReadLine();
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
        public string Passoword()
        {
            Console.WriteLine("Enter Password must be include 8 Characters ");
            string password = Console.ReadLine();
            string Numberregex = "^[a-zA-Z]{8,}";
            Regex regexlast = new Regex(Numberregex);
            if (regexlast.IsMatch(password))
            {
                Console.WriteLine(password + " Number is valid");
                return password;
            }
            else
            {
                Console.WriteLine(password + " Number is invalid");
                return null;
            }
        }
        public string Passoword_Rule2()
        {
            Console.WriteLine("Enter Password must be include 8 Characters and atleast 1 Upper case ");
            string password = Console.ReadLine();
            string Numberregex = "^(?=^.{8,}$)(?=.*?[A-Z])(?=.*[a-z]).*$";
            Regex regexlast = new Regex(Numberregex);
            if (regexlast.IsMatch(password))
            {
                Console.WriteLine(password + " Number is valid");
                return password;
            }
            else
            {
                Console.WriteLine(password + " Number is invalid");
                return null;
            }
        }
    }
}
