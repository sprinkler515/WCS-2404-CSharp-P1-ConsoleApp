namespace P1_AppConsole.Menus
{
    public class CampusManager : Menu, IDisplay
    {
        protected Campus Campus { get; set; }

        public CampusManager()
        {
            Campus = new("Wild Code School");

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
                Display();
                Select();
                switch (Option)
                {
                    case 1:
                        StudentsManager studentsManager = new();
                        studentsManager.Selection();
                        break;
                    case 2:
                        SubjectsManager subjectsManager = new();
                        subjectsManager.Selection();
                        break;
                    case 3:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine(
                            "Error! Please select a valid option.\n");
                        break;
                }
            }
        }

        public void Display()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
            Console.WriteLine($"\n{DateTime.Now} - Welcome\n");

            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }
    }
}
