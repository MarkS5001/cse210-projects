class Menu
{
    private int _totalPoints = 0;
    private List<Goal> _goals = new List<Goal>();
    private int _menuChoice;
    public void GetFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        int counter = 0;

        foreach (string line in lines)
        {
            if (counter == 0)
            {
                _totalPoints = int.Parse(line);
                counter = 1;
            }
            else
            {
                string[] parts = line.Split("~");

                if (parts[0] == "EternalGoal")
                {
                    Goal currentGoal = new Goal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(currentGoal);
                }
                else if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal currentGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                    _goals.Add(currentGoal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal currentGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(currentGoal);
                }
            }
        }
    }
    public void SaveFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void MenuLoop()
    {
        while (_menuChoice != 6)
        {
            Console.WriteLine($"You have {_totalPoints} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _menuChoice = int.Parse(Console.ReadLine());

            if (_menuChoice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("  1. Simple goal");
                Console.WriteLine("  2. Eternal goal");
                Console.WriteLine("  3. Checklist goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int currentChoice = int.Parse(Console.ReadLine());

                if (currentChoice == 1)
                {
                    SimpleGoal currentGoal = new SimpleGoal();
                    currentGoal.GetGoal();
                    _goals.Add(currentGoal);
                }
                else if (currentChoice == 2)
                {
                    Goal currentGoal = new Goal();
                    currentGoal.GetGoal();
                    _goals.Add(currentGoal);
                }
                else if (currentChoice == 3)
                {
                    ChecklistGoal currentGoal = new ChecklistGoal();
                    currentGoal.GetGoal();
                    _goals.Add(currentGoal);
                }
            }

            else if (_menuChoice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("The goals are: ");
                int i = 0;

                foreach (Goal currentGoal in _goals)
                {
                    i++;
                    Console.WriteLine($"{i}.  {currentGoal.Display()}");
                }
            }

            else if (_menuChoice == 3)
            {
                SaveFile();
            }

            else if (_menuChoice == 4)
            {
                GetFile();
            }

            else if (_menuChoice == 5)
            {
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                int i = 0;

                foreach (Goal currentGoal in _goals)
                {
                    i++;
                    Console.WriteLine($"{i}.  {currentGoal.GetName()}");
                }
                Console.WriteLine("Which goal did you accomplish? ");
                int userChoice = int.Parse(Console.ReadLine());

                int pointsEarned = _goals[userChoice-1].RecordEvent();
                _totalPoints += pointsEarned;

                Console.WriteLine();
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_totalPoints} points!");
            }
        }
    }
}