using System;

namespace Mindfulness
{
    class Reflecting: Activity
    {
        public Reflecting() : base("Reflecting Activity", "This activity will help you Reflect by asking yourself a random thoughtful question.") {}
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
            List <string> followupQuestions = new List<string>() 
            {
                "How did that make you feel?",
                "What did you learn from that experience?",
                "What would you do differently next time?",
                "What can you do to make that happen?",
                "What can you do to prevent that from happening?",
                "What can you do to make that happen?",
                "What can you do to make that happen?",
            };


            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Consider the following question:");
                Random random = new Random();
                int index = random.Next(questions.Count);
                Console.WriteLine(questions[index]);
                Console.WriteLine("\nWhen you are ready, press any key to continue.");
                Console.ReadKey();
                Console.WriteLine("Now, take a moment to reflect on your answer. and Answer the following question:");
                ShowCountDown(5);
                Console.Clear();
                if(DateTime.Now < endTime)
                {
                    Console.WriteLine("Consider the following follow-up question:\n");
                    while (DateTime.Now < endTime && followupQuestions.Count > 0 )
                    {
                        index = random.Next(followupQuestions.Count);
                        Console.WriteLine(followupQuestions[index]);
                        followupQuestions.RemoveAt(index);
                        ShowSpinner(5); 
                    }
                }
            }
            DisplayEndingMessage();
        }
    }
}