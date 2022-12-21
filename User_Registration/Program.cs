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
                Console.WriteLine("1 Firstname \n2 Lastname \n3 Email \n4. Phonenumber \n5 Password \n6. Password rule2 atleast 1 Upper case\n7. Password rule3  atleast 1 Upper case and 1 number");
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
                    case 6:
                        valid.Passoword_Rule2();
                        break;
                    case 7:
                        valid.Passoword_Rule3();
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        break;
                }
            }
            

        }
    }
}
