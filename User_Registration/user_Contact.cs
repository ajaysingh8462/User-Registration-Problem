using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Registration
{
    public class user_Contact
    {
        public string Firstname(string Name) 
        {
            
            string firstnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexfirst = new Regex(firstnameregex);
            if (regexfirst.IsMatch(Name))
            {
                Console.WriteLine(Name + " FirstName is valid");
                return Name;
            }
            else
            {
                Console.WriteLine(Name + " FirstName is invalid");
                return null;
            }
        }
        public string Lastname(string Name)
        {
            
            string lastnameregex = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexlast = new Regex(lastnameregex);
            if (regexlast.IsMatch(Name))
            {
                Console.WriteLine(Name+ " LastName is valid");
                return Name;
            }
            else
            {
                Console.WriteLine(Name + " LastName is invalid");
                return null;
            }
        }
        public string Email(string email)
        {
            
            var emailregex = "^[0-9A-Za-z]+(.[0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
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
            
            string Numberregex = "^[0-9]{1,3} [6-9]{1}[0-9]{9}$";
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
        public string Passoword(string password)
        {
            
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
        public string Passoword_Rule2(string password)
        {
            
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
        public string Passoword_Rule3(string password)
        {
            
            string Numberregex = "^(?=^.{8,}$)(?=.*?[0-9])(?=.*?[A-Z])(?=.*[a-z]).*$";
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
        public string Passoword_Rule4(string password)
        {
            
            string Numberregex = "^(?=^.{8,}$)(?=.*?[0-9])(?=.*[@$!%*?&#)(?=.*?[A-Z])(?=.*[a-z]).*$";
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
        public string Email_All()
        {
            Console.WriteLine("Enter Email ");
            string email = Console.ReadLine();
            var emailregex = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";
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
    }
}
