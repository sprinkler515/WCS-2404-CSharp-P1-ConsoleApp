namespace P1_AppConsole
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ProgramConsole();
        }

        static void ProgramConsole()
        {
            Menu menu = new();

            while (!menu.Exit)
            {
                menu.Select();

                if (menu.Option == 1)
                {
                    Console.WriteLine("Students");
                }
                else if (menu.Option == 2)
                {
                    Console.WriteLine("Subjects");
                }
            }
        }
    }
}
