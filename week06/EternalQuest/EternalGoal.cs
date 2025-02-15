using System;

namespace EternalQuest {
    class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points) {
        }
        public override void RecordEvent() 
        {
            IsComplete();
        }
        public override bool IsComplete()
        {
            return false;        
        }
        public override string GetDetailString()
        {
            return $"[ ] {_shortName} ({_description})";
        }
        public override string GetStringRepresentation()
        {
            return $"eternalgoal:{_shortName},{_description},{_points}";
        }
    }
}
