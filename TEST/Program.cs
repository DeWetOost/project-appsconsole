using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for their name
            Console.WriteLine("Enter username");

            // Create a string variable and store userName provided in the variable
            string userName = Console.ReadLine();
        
            // Display Hello message with userName
            Console.WriteLine("Hello " + userName);

            // Ask the user a question
            Console.WriteLine("Are you having a good day? (Y/N)");

            // Display response depending on their answer
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key.ToString() == "Y")
            {
                Console.WriteLine("\nThat is great! Hope your day continues like this");
            }
            else if (cki.Key.ToString() == "N")
            {
                Console.WriteLine("\nThat is a shame. Hope your day gets better from here");
            }
            else
            {
                Console.WriteLine("\nPlease ensure to select either Y or N");
            }
        }     
    }
}
