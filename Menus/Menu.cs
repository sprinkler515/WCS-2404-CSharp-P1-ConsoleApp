namespace P1_AppConsole.Menus
{
    public abstract class Menu
    {
        protected List<string> Options { get; set; } = [];
        protected bool Exit { get; set; }
        protected int Option { get; set; }

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
                    if (s.Contains(select) && select.Length >= 3)
                        Option = i;
                }
            Console.WriteLine();
        }

        protected abstract void Selection();

        public static void DrawLine()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }
    }
}
