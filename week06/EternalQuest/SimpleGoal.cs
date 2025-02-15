using System;

namespace EternalQuest {
    class SimpleGoal : Goal
    {
        private bool _isComplete;
        public SimpleGoal(string shortName, string description, int points, bool completed = false) : base(shortName, description, points) {
            _isComplete = completed;
        }
        public override void RecordEvent()
        {
            _isComplete = true;           
        }
        public override bool IsComplete()
        {
            return _isComplete;        
        }
        public override string GetDetailString()
        {
            var marker = _isComplete ? "[X]" : "[ ]";
            return $"{marker} {_shortName} ({_description})";
        }
        public override string GetStringRepresentation()
        {
            return $"simplegoal:{_shortName},{_description},{_points},{_isComplete}";
        }
    }
}
