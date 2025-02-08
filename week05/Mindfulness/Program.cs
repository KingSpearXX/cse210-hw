using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Options");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflective Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Activity selectedActivity = choice switch
                {
                    1 => new Breathing(),
                    2 => new Reflecting(),
                    3 => new Listing(),
                    _ => null
                };
                if (selectedActivity != null)
                {
                    selectedActivity.Run();
                }

            } while (choice != 4);
        }
    }
}