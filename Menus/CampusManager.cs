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
                        Console.WriteLine("Error! Please select a valid option.\n");
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
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

        public static void DrawLine()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }
    }
}
