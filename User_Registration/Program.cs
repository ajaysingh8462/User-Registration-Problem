using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Registration
{
    public class program
    {
        public static void Main(string[] args)
        {
            user_Contact valid= new user_Contact();
            while (true) 
            {
                Console.WriteLine("1 Firstname \n2 Lastname \n3 Email \n4. Phonenumber \n5 Password \n6. Password rule2 atleast 1 Upper case\n7. Password rule3  atleast 1 Upper case and 1 number\n8. Password rule3  atleast 1 Upper case, 1 number and 1 special character ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Firstname Must be incude First character as cap");
                        string name = Console.ReadLine();
                        valid.Firstname(name);
                        break;
                    case 2:
                        Console.WriteLine("Enter Lastname Must be incude First character as cap");
                        string lname = Console.ReadLine();
                        valid.Lastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email ");
                        string email = Console.ReadLine();
                        valid.Email(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Phonenumber eg- (1,91,92 -etc) 9855515254 ");
                        string number = Console.ReadLine();
                        valid.Number(number);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password must be include 8 Characters ");
                        string password = Console.ReadLine();
                        valid.Passoword(password);
                        break;
                    case 6:
                        Console.WriteLine("Enter Password must be include 8 Characters and atleast 1 Upper case ");
                        string password_2 = Console.ReadLine();
                        valid.Passoword_Rule2(password_2);
                        break;
                    case 7:
                        Console.WriteLine("Enter Password must be include 8 Characters and atleast 1 Upper case and atleast 1 number ");
                        string password_3 = Console.ReadLine();
                        valid.Passoword_Rule3(password_3);
                        break;
                    case 8:
                        Console.WriteLine("Enter Password must be include 8 Characters and atleast 1 Upper case and atleast 1 number ");
                        string password_4 = Console.ReadLine();
                        valid.Passoword_Rule4(password_4);
                        break;
                    case 9:
                        valid.Email_All();
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        break;
                }
            }
            

        }
    }
}
