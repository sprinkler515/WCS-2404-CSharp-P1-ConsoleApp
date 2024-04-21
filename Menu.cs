namespace P1_AppConsole
{
    public static class Menu
    {
        public static void DisplayMenu(string[] menu)
        {
            foreach (string option in menu)
                Console.WriteLine(option);
            Console.WriteLine();
        }

        public static int SelectMenu(string[] menu)
        {
            string choice;
            bool isNumber;

            Console.Write("Enter your choice: ");
            choice = Console.ReadLine() ?? "";
            choice = choice.ToLower();
            isNumber = int.TryParse(choice, out int option);

            if (!isNumber)
                for (int i = 1; i <= menu.Length; i++)
                {
                    string s = menu[i - 1].ToLower();
                    if (s.Contains(choice))
                        option = i;
                }
            if (option <= 0 || option > menu.Length)
                Console.WriteLine("Invalid input");

            return option;
        }
    }
}
