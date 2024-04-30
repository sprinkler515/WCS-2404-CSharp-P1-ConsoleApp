namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        protected List<string> Options { get; set; } = [];
        protected bool Exit { get; set; }
        protected int Option { get; set; }

        protected void Select()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int option))
                Option = option;
            Console.WriteLine();
        }

        protected void OptionError()
        {
            Console.WriteLine("Error! Please select a valid option.\n");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }

        public static void DrawLine()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }

        protected abstract void Selection();
    }
}
