using System;

namespace Mindfulness
{
    class Listing: Activity
    {
        public Listing() : base("Reflecting Activity", "This activity will help you Reflect by asking yourself a random thoughtful question.") {}
        public override void Run()
        {
            DisplayStartingMessage();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            List <string> questions = new List<string>
            {
                "What are you grateful for today?",
                "What is something you learned today?",
                "What is something you did today that you are proud of?",
                "What is something you did today that you wish you could have done differently?",
                "What is something you are looking forward to tomorrow?",
                "What is something you are looking forward to in the future?",
                "What is something you are worried about?",
            };
            List <string> thoughts = new List<string>();
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Consider the following question:");
                Random random = new Random();
                int index = random.Next(questions.Count);
                Console.WriteLine(questions[index]);
                Console.WriteLine("\nList Down your thoughts and press any enter to continue.");
                while (DateTime.Now < endTime)
                {
                    Console.Write("> ");
                    thoughts.Add(Console.ReadLine());
                }
            }
            Console.WriteLine($"You have listed ({thoughts.Count}) thoughts.");
            DisplayEndingMessage();
        }
    }
}