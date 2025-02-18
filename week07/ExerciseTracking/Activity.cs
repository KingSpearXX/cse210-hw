using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    abstract class Activity
    {
        private DateTime date;
        private int length; 

        public Activity(DateTime date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int Length
        {
            get { return length; }
        }

        public abstract double GetDistance(); 
        public abstract double GetSpeed(); 
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Length} min): " +
                $"Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, " +
                $"Pace: {GetPace():F2} min per km";
        }
    }
}