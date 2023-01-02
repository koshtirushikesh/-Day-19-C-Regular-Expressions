namespace RegexDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();

            Console.WriteLine("Enter a First Name:");
            string UserFirstName = Console.ReadLine();

            if (pattern.validateUserName(UserFirstName))
            {
                Console.WriteLine(" valid First Name ");
            }
            else
            {
                Console.WriteLine(" not a valid First Name ");
            }

            Console.WriteLine("Enter a Last Name:");
            string UserLastName = Console.ReadLine();

            if (pattern.validateUserName(UserLastName))
            {
                Console.WriteLine(" valid Last Name ");
            }
            else
            {
                Console.WriteLine(" not a valid Last Name ");
            }
        }
    }
}