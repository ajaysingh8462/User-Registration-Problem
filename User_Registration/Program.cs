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
            user_Contact valid= new user_Contact();
            while (true) 
            {
                Console.WriteLine("1 Firstname \n2 Lastname \n3 Email \n4. Phonenumber \n5 Password");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        valid.Firstname();
                        break;
                    case 2:
                        valid.Lastname();
                        break;
                    case 3:
                        valid.Email();
                        break;
                    case 4:
                        valid.Number();
                        break;
                    case 5:
                        valid.Passoword();
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        break;
                }
            }
            user_Contact firstn= new user_Contact();
            firstn.Firstname();
            user_Contact lastn = new user_Contact();
            lastn.Lastname();
            user_Contact emailn = new user_Contact();
            emailn.Email();
            user_Contact Phnum = new user_Contact();
            Phnum.Number();
            user_Contact passwordn = new user_Contact();
            passwordn.Passoword();

        }
    }
}
