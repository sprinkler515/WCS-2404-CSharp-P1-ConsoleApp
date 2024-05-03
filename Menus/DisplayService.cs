using P1_AppConsole.Interfaces;

namespace P1_AppConsole.Menus
{
    public class DisplayService : IDisplay
    {
        public void Display(Menu menu, string name)
        {
            Header();
            Console.WriteLine(name);
            DisplayOptions(menu);
        }

        public void DisplayOptions(Menu menu)
        {
            foreach (string option in menu.Options)
                Console.WriteLine($"{String.Empty,2}{option}");
            Footer();
        }

        public void OptionError()
        {
            Console.WriteLine("Error! Please select a valid option.\n");
            Control();
        }

        public void Control()
        {
            Console.Write("Press return to continue...");
            Console.ReadLine();
        }

        public void Header()
        {
            Console.Clear();
            Separator();
            Console.WriteLine();
        }

        public void Footer()
        {
            Console.WriteLine();
            Separator();
            Console.WriteLine('\n');
        }

        public void Separator()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }
    }
}
