using System;

namespace Mindfulness
{
    class Breathing: Activity
    {
        public Breathing() : base("Breathing Activity", "This activity will help you relax by walking through your breathing in and out slowly, Clear your mind and focus your breathing.") {}
        public override void Run()
        {
            DisplayStartingMessage();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine("Breathe out...");
                ShowCountDown(4);
                Console.Write("\r");
                Console.WriteLine(" ");
            }
            DisplayEndingMessage();
        }
    }
}