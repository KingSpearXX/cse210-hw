using System;

namespace EternalQuest {
    public abstract class Goal
    {
        protected string _shortName { get; set; }
        protected string _description { get; set; }
        public int _points { get; set; }
        
        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailString();       
        public abstract string GetStringRepresentation();
        
    }
}
