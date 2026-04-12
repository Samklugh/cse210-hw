using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine()?.Trim() ?? "";

            Console.WriteLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice != "6")
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        string title = GetLevelTitle();
        Console.WriteLine($"You have {_score} points. Level: {title}");
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine()?.Trim() ?? "";

        string name = PromptString("What is the name of your goal? ");
        string description = PromptString("What is a short description of it? ");
        int points = PromptInt("What is the amount of points associated with this goal? ");

        if (typeChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (typeChoice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (typeChoice == "3")
        {
            int target = PromptInt("How many times does this goal need to be accomplished for a bonus? ");
            int bonus = PromptInt("What is the bonus for accomplishing it that many times? ");
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type. No goal created.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        int choice = PromptInt("Which goal did you accomplish? ");
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selected = _goals[choice - 1];
        int earned = selected.RecordEvent();
        if (earned > 0)
        {
            _score += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete. No points awarded.");
        }

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        string filename = PromptString("What is the filename for the goal file? ");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        string filename = PromptString("What is the filename for the goal file? ");

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _goals.Clear();
        _score = 0;

        int parsedScore;
        if (int.TryParse(lines[0], out parsedScore))
        {
            _score = parsedScore;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split("|");
            if (parts.Length < 4)
            {
                continue;
            }

            string type = parts[0];
            if (type == "SimpleGoal" && parts.Length >= 5)
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal" && parts.Length >= 7)
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    private string PromptString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine()?.Trim() ?? "";
    }

    private int PromptInt(string prompt)
    {
        int value;
        Console.Write(prompt);
        string input = Console.ReadLine();

        while (!int.TryParse(input, out value))
        {
            Console.Write("Please enter a number: ");
            input = Console.ReadLine();
        }

        return value;
    }

    private string GetLevelTitle()
    {
        if (_score >= 5000)
        {
            return "Luminary";
        }
        if (_score >= 3000)
        {
            return "Pathfinder";
        }
        if (_score >= 1500)
        {
            return "Disciple";
        }
        if (_score >= 500)
        {
            return "Builder";
        }
        return "Seeker";
    }
}
