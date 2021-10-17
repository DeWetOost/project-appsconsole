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

            // Ask user random question from a list of 3 questions
            var questions = new List<Question>()
            {
                new Question { Text = "What is the capital of France?", Answer = "Paris" };
                new Question { Text = "What is the largest mammal?", Answer = "Blue whale" };
                new Question { Text = "Who is the current UK Prime Minister?", Answer = "Boris Johnson" };
            }
            Random random = new Random();

            foreach (var question in questions.OrderBy(q => random.Next()))
            {
                Console.WriteLine(question.Text);

                do
                {
                    var answer = Console.ReadLine();
                    if (question.IsCorrect(answer))
                    {
                        Console.WriteLine("It's True");
                        break;
                    }

                Console.WriteLine("It's False. Please try again.");
                }
            while (true);
            }
        }     
    }
}
