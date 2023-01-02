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
        }
    }
}