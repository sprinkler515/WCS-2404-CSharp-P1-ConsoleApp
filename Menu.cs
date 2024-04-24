using Microsoft.VisualBasic.FileIO;

namespace P1_AppConsole
{
    public abstract class Menu
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
            choice = Console.ReadLine() ?? "Invalid input";
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

        public static int MainMenu()
        {
            string[] menu = [
                "1. Students",
                "2. Subjects",
                "3. Exit"
                ];

            DisplayMenu(menu);
            return SelectMenu(menu);
        }

        public static int StudentMenu()
        {
            string[] menu = [
                "1. List students",
                "2. Create student",
                "3. Consult specific student",
                "4. Add grade to a specific student",
                "5. Back to menu"
                ];

            DisplayMenu(menu);
            return SelectMenu(menu);
        }
    }
}
