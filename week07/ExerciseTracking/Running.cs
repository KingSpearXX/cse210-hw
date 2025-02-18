using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Running : Activity
    {
        private double distance;

        public Running(DateTime date, int length, double distance)
            : base(date, length)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Length) * 60;
        }

        public override double GetPace()
        {
            return Length / GetDistance();
        }
    }
}