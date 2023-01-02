using System.Text.RegularExpressions;

namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();

            //Console.WriteLine("Enter a First Name:");
            //string UserFirstName = Console.ReadLine();

            //if (pattern.validateUserName(UserFirstName))
            //{
            //    Console.WriteLine(" valid First Name ");
            //}
            //else
            //{
            //    Console.WriteLine(" not a valid First Name ");
            //}

            //Console.WriteLine("Enter a Last Name:");
            //string UserLastName = Console.ReadLine();

            //if (pattern.validateUserName(UserLastName))
            //{
            //    Console.WriteLine(" valid Last Name ");
            //}
            //else
            //{
            //    Console.WriteLine(" not a valid Last Name ");
            //}

            //Console.WriteLine("Enter a Phone Number");
            //string PhoneNumber = Console.ReadLine();

            //if (pattern.validatePhoneNumber(PhoneNumber))
            //{
            //    Console.WriteLine(" valid phone number ");
            //}
            //else
            //{
            //    Console.WriteLine(" not a valid phone number ");
            //}

            Console.WriteLine("Enter a PassWord");
            string Password = Console.ReadLine();

            if (pattern.ValidatePassword(Password))
            {
                Console.WriteLine(" valid Password ");
            }
            else
            {
                Console.WriteLine(" not a valid Password ");
            }


        }
    }
}