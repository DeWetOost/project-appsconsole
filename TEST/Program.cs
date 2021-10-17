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
                Console.WriteLine("\nThat is great " + userName +"! Hope your day continues like this");
            }
            else if (cki.Key.ToString() == "N")
            {
                Console.WriteLine("\nAh bummer, " + userName + ". Hope your day gets better from here");
            }
            else
            {
                Console.WriteLine("\nPlease ensure to select either Y or N");
            }

            // Random question to give user
            private static List<KeyValuePair<string, string>> questions = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string,string>("-What is the capital of France", "Paris"),
                new KeyValuePair<string,string>("-What is the capital of Spain", "Madrid"),
                new KeyValuePair<string,string>("-What is the captial of Russia", "Moscow"),
                new KeyValuePair<string,string>("-What is the capital of Ukraine", "Kiev"),
                new KeyValuePair<string,string>("-What is the capital of Egypt", "Cairo"),
            };

            static void Main()
            {
                var questions = ShuffleQuestions();

                foreach(var question in questions)
                {
                    bool done = false;
                    while(!done)
                    {
                        Console.WriteLine(question.Key);
                        string a = Console.ReadLine();

                        if (a == question.Value)
                        {
                            Console.WriteLine("It's True \n*Next Question is:");
                            done = true;
                        }
                        else
                            Console.WriteLine("It's False \n*Please Try Again.");
                    }
                }

            Console.ReadLine();
            }

            private IEnumerable<KeyValuePair<string, string>> ShuffleQuestions()
            {
                var list = questions;
                var random = new Random();  
                int items = list.Count;  
                while (items > 1) 
                {  
                    items--;  
                    int nextItem = random.Next(items + 1);  
                    var value = list[nextItem];  
                    list[nextItem] = list[items];  
                    list[items] = value;  
                }
                return list;
            }
        }     
    }
}
