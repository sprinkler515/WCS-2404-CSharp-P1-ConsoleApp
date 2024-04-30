namespace P1_AppConsole.Menus
{
    public class CampusManager : Menu, IDisplay
    {
        protected Campus Campus { get; set; }

        public CampusManager()
        {
            Campus = new();

            Options.Add("1. Students");
            Options.Add("2. Subjects");
            Options.Add("3. Exit");
        }

        public void StartProgram()
        {
            Selection();
        }

        protected override void Selection()
        {
            while (!Exit)
            {
                Console.Clear();
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        new StudentsManager().Selection();
                        break;
                    case 2:
                        new SubjectsManager().Selection();
                        break;
                    case 3:
                        Exit = true;
                        break;
                    default:
                        OptionError();
                        break;
                }
            }
        }

        public void Display()
        {
            DrawLine();
            Console.WriteLine($"\n{DateTime.Now} - Welcome\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

    }
}
