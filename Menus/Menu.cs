namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        public List<string> Options { get; private set; }
        public bool Exit { get; protected set; }
        public int Option { get; protected set; }

        public Menu()
        {
            Options = [];
            Option = 0;
            Exit = false;
        }

        protected void Display()
        {
            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        protected void Select()
        {
            string select;
            bool valid;

            Console.Write("Enter your choice: ");
            select = Console.ReadLine() ?? "Invalid input";
            select = select.ToLower();
            valid = int.TryParse(select, out int option);
            Option = option;

            if (!valid)
                for (int i = 1; i <= Options.Count; i++)
                {
                    string s = Options[i - 1].ToLower();
                    if (s.Contains(select) && s.Length >= 3)
                        Option = i;
                }
            Console.WriteLine();
        }

        public abstract void Selection(Campus campus);
    }
}
