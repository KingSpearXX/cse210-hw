using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Swimming : Activity
    {
        private int laps;
        private const double lapDistance = 50.0 / 1000;

        public Swimming(DateTime date, int length, int laps)
            : base(date, length)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * lapDistance;
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