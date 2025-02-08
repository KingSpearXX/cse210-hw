using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace Mindfulness
{
    class Activity
    {
        private string _name;
        private string _description;
        public int _duration { get; set; }
        
         public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }
        
        public void DisplayStartingMessage()
        {
            try 
            {
                Console.WriteLine($"Welcome to the {_name} activity!\n");
                Console.WriteLine(_description);
                Console.Write("\nHow long, in seconds, would you like for the Session? ");
                this._duration = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Get Ready to Begin!");
                ShowSpinner(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }     
        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine($"\nYou have completed the {_name} activity for {_duration} of seconds!");
            Console.WriteLine($"Well done! You have completed the {_name} activity!, Press any key to continue.");
            Console.ReadKey();
        }
        
        public void ShowCountDown(int duration)
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\r");
            }
        }
        public void ShowSpinner(int duration)
        {
            List<string> animation = "|\\-/".ToCharArray().Select(c => c.ToString()).ToList();

            for (int i = 0; i < duration; i++)
            {
                Console.Write(animation[i % animation.Count]);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.Write("\b ");
            Console.WriteLine();
        }
        public virtual void Run()
        {
            Console.WriteLine("This activity has no specific implementation.");
        }
    }
}