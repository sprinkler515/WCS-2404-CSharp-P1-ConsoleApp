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
                        DisplayControl();
                        break;
                    case 2:
                        Campus.CreateSubject();
                        DisplayControl();
                        break;
                    case 3:
                        Campus.RemoveSubject();
                        DisplayControl();
                        break;
                    case 4:
                        Exit = true;
                        break;
                    default:
                        OptionError();
                        break;
                }
            }
        }

        public new void Display()
        {
            DrawLine();
            Console.WriteLine("\nSubjects :\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
