using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Cycling : Activity
    {
        private double speed; 

        public Cycling(DateTime date, int length, double speed)
            : base(date, length)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed * Length) / 60;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }
    }
}