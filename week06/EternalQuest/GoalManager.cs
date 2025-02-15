using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace EternalQuest {
    class GoalManager
    {
        public List<Goal> _goals { get; set; }
        public int _score { get; set; }

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
        public void Start()
        {
            var gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                Console.WriteLine($"Your Score: {_score}");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                var choice = Console.ReadLine();
                var filename = "";
                switch (choice)
                {
                    case "1":
                        this.CreateNewGoal();
                        break;
                    case "2":
                        Console.Clear();
                        int i = 1;
                        foreach (var goal in _goals)
                        {
                            Console.WriteLine($"{i} - {goal.GetDetailString()}");
                            i++;    
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter the filename to save the goals: ");
                        filename = Console.ReadLine();                       
                        using (StreamWriter outputFile = new StreamWriter($"{filename}.txt"))
                        {
                            outputFile.WriteLine(_score);
                            foreach (var goal in _goals)
                            {
                                outputFile.WriteLine(goal.GetStringRepresentation());
                            }
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter the filename to load the goals: ");
                        filename = Console.ReadLine();
                        try {
                            File.OpenRead($"{filename}.txt");
                        } catch (FileNotFoundException ex) {
                            Console.WriteLine($"File not found: {ex.Message}. Press any key to continue.");
                            Console.ReadKey();
                            break;  
                        }
                        using (StreamReader inputFile = new StreamReader($"{filename}.txt"))
                        {
                            _score = Convert.ToInt32(inputFile.ReadLine());
                            _goals.Clear();
                            while (!inputFile.EndOfStream)
                            {
                                var line = inputFile.ReadLine();
                                var parts = line.Split(',');
                                var type = parts[0].Split(':')[0];
                                var shortName = parts[0].Split(':')[1];
                                var description = parts[1];
                                var points = Convert.ToInt32(parts[2]);
                                switch (type)
                                {
                                    case "simplegoal":
                                        _goals.Add(new SimpleGoal(shortName, description, points, Convert.ToBoolean(parts[3])));
                                        break;
                                    case "eternalgoal":
                                        _goals.Add(new EternalGoal(shortName, description, points));
                                        break;
                                    case "checklistgoal":
                                        _goals.Add(new ChecklistGoal(shortName, description, points, Convert.ToInt32(parts[4]), Convert.ToInt32(parts[3])));                                       
                                        ((ChecklistGoal)_goals[_goals.Count - 1])._currentCount = Convert.ToInt32(parts[5]);
                                        break;
                                }
                            }
                            Console.WriteLine("Goals loaded successfully. Press any key to continue.");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.Clear();
                        var index = 0;
                        Dictionary<int, Goal> incompleteGoals = new Dictionary<int, Goal>();
                        foreach (var goal in _goals)
                        {
                            index++;
                            if(!goal.IsComplete()) {
                                incompleteGoals.Add(index, goal);
                            }
                        }
                        if(incompleteGoals.Count == 0)
                        {
                            Console.WriteLine("No goals to record events for. Press any key to continue.");
                            Console.ReadKey();
                        } else {
                            index = 0;
                            foreach (var goal in incompleteGoals)
                            {
                                index++;
                                Console.WriteLine($"{index} - {goal.Value.GetDetailString()}");
                            }
                            Console.WriteLine("Enter the number of the goal you want to record an event for: ");
                            var goalNumber = Convert.ToInt32(Console.ReadLine());
                            var indexKey = incompleteGoals.Keys.ElementAt(goalNumber - 1);
                            _goals[indexKey - 1].RecordEvent();
                            _score += _goals[indexKey - 1]._points;
                            Type type = _goals[indexKey - 1].GetType();
                            if (type == typeof(ChecklistGoal))
                            {
                                if (_goals[indexKey - 1].IsComplete())
                                {
                                    _score += ((ChecklistGoal)_goals[indexKey - 1])._bonusPoints;
                                }
                            }
                            Console.WriteLine("Event recorded successfully. Press any key to continue.");
                            Console.ReadKey();
                        }
                        break;
                    case "6":
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void CreateNewGoal()
        {
            var correctChoice = false;
            while (!correctChoice)
            {
                Console.Clear();
                Console.WriteLine("The types of goals you can create are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Back");
                Console.Write("Select a choice from the menu: ");
                var choice = Console.ReadLine();
                string shortName = "";
                string description = "";
                int points = 0;
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the short name of the goal: ");
                        shortName = Console.ReadLine();
                        Console.Write("Enter the description of the goal: ");
                        description = Console.ReadLine();
                        Console.Write("Enter the points of the goal: ");
                        points = Convert.ToInt32(Console.ReadLine());
                        _goals.Add(new SimpleGoal(shortName, description, points));
                        correctChoice = true;
                        break;
                    case "2":
                        Console.Write("Enter the short name of the goal: ");
                        shortName = Console.ReadLine();
                        Console.Write("Enter the description of the goal: ");
                        description = Console.ReadLine();
                        Console.Write("Enter the points of the goal: ");
                        points = Convert.ToInt32(Console.ReadLine());
                        _goals.Add(new EternalGoal(shortName, description, points));
                        correctChoice = true;
                        break;
                    case "3":
                        Console.Write("Enter the short name of the goal: ");
                        shortName = Console.ReadLine();
                        Console.Write("Enter the description of the goal: ");
                        description = Console.ReadLine();
                        Console.Write("Enter the points of the goal: ");
                        points = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the target count of the goal: ");
                        var targetCount = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the bonus points of the goal: ");
                        var bonusPoints = Convert.ToInt32(Console.ReadLine());
                        _goals.Add(new ChecklistGoal(shortName, description, points, targetCount, bonusPoints));
                        correctChoice = true;
                        break;
                    case "4":
                        correctChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
            

        }
    }
}
