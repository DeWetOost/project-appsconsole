using System;

namespace Exercise1
{
    class Program
    {
        static void RandomQuestion()
        {
                Random question = new Random();
                int x = question.Next(3);
                string[] array = new string[3];
                array[0] = "What is the capital of France?";
                array[1] = "What is the largest mammal?";
                array[2] = "Who is the current Prime Minister of the UK?";

                Console.WriteLine(array[x]);

                string[] answer = new string[3];
                answer[0] = "Paris";
                answer[1] = "Blue whale";
                answer[2] = "Boris Johnson";

                bool incorrect = true;
                while(incorrect)
                {
                    string a = Console.ReadLine();
                    if (a == answer[x])
                    {
                        Console.WriteLine("Well done! You have passed the test");
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not entirely correct \n*Please Try Again.");
                    }
                }
        }

        static void Main(string[] args)
        {
            // Ask user for their name
            Console.WriteLine("Enter username");

            // Create a string variable and store userName provided in the variable
            string userName = Console.ReadLine();
        
            // Display Hello message with userName
            Console.WriteLine($"Hello {userName}!");

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
                Console.WriteLine("\nAh bummer. Hope your day gets better from here");
            }
            else
            {
                Console.WriteLine("\nPlease ensure to select either Y or N");
            }

            // Random question to give user
            RandomQuestion();
        }     
    }
}