using System;

namespace EternalQuest {
    class ChecklistGoal : Goal
    {
        public int _currentCount { get; set; }
        public int _targetCount { get; set; }
        public int _bonusPoints { get; set; }   
        public ChecklistGoal(string shortName, string description, int points, int target, int bonusPoints) : base(shortName, description, points) {
            _currentCount = 0;
            _targetCount = target;
            _bonusPoints = bonusPoints;
        }
        public override void RecordEvent()
        {
            _currentCount++;
        }
        public override bool IsComplete()
        {
            if (_currentCount >= _targetCount) 
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
        public override string GetDetailString()
        {
            var marker = IsComplete() ? "[X]" : "[ ]";
            return $"{marker} {_shortName} ({_description}) [{_currentCount}/{_targetCount}]";
        }
        public override string GetStringRepresentation()
        {
            return $"checklistgoal:{_shortName},{_description},{_points},{_bonusPoints},{_targetCount},{_currentCount}";
        }
    }
}
