using System;


namespace ExerciseTracking
{
    class Program
    {
        static void Main()
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2025, 5, 21), 30, 5),
                new Cycling(new DateTime(2025, 3, 12), 40, 20), 
                new Swimming(new DateTime(2025, 12, 19), 25, 30) 
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
