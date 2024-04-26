namespace P1_AppConsole.Menus
{
    public class SubjectsManager : CampusManager, IDisplay
    {
        public SubjectsManager()
        {
            Options.Clear();
            Options.Add("1. List subjects");
            Options.Add("2. Add new subject");
            Options.Add("3. Delete subject");
            Options.Add("4. Back to menu");
        }

        protected override void Selection()
        {
            while (!Exit)
            {
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        Campus.DisplaySubjects();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Error. Please select a valid option.");
                        break;
                }
            }
        }

        public new void Display()
        {
            int len = 70;

            for (int i = 0; i < len; i++)
                Console.Write("-");
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
