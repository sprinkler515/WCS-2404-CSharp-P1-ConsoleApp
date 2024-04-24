namespace P1_AppConsole.menu
{
    public abstract class Menu
    {
        public List<string> Options;
        public int Option;
        public bool Exit;

        public Menu()
        {
            Options = [];
            Option = 0;
            Exit = false;
        }

        public void Display()
        {
            foreach (string option in Options)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public void Select()
        {
            string select;
            bool valid;

            Console.Write("Enter your choice: ");
            select = Console.ReadLine() ?? "Invalid input";
            select = select.ToLower();
            valid = int.TryParse(select, out Option);

            if (!valid)
                for (int i = 1; i <= Options.Count; i++)
                {
                    string s = Options[i - 1].ToLower();
                    if (s.Contains(select) && s.Length >= 3)
                        Option = i;
                }
            /*
            if (Option <= 0 || Option > Options.Count)
                Console.WriteLine("Invalid input");
            */
        }

        public abstract void Selection();
    }
}
