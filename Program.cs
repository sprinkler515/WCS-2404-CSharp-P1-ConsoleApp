using P1_AppConsole.Menus;

namespace P1_AppConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Campus campus = new();
            MainMenu menu = new();

            menu.Selection(campus);
            */
            Dictionary<int, string> test = [];
            test.Add(1, "Hello");
            test.Add(2, "World");

            //test.Add(1, "yes");
            foreach (var kvp in test)
            {
                Console.WriteLine(kvp.Key + ' ' + kvp.Value);
            }

        }
    }
}
