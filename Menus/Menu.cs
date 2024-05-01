namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        public List<string> Options { get; set; }
        public int Option { get; set; }
        public bool Exit { get; set; }

        public Menu()
        {
            Options = [];
        }

        protected void Select()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int option))
                Option = option;
            Console.WriteLine();
        }

        protected static void DisplayControl()
        {
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }

        protected static void OptionError()
        {
            Console.WriteLine("Error! Please select a valid option.\n");
            DisplayControl();
        }

        protected static void DrawLine()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }
    }
}
