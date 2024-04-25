namespace P1_AppConsole
{
    public abstract class Tools
    {
        public static string NameEntry()
        {
            string name = "";

            while (String.IsNullOrEmpty(name))
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(name) || name.Length < 2)
                    Console.WriteLine(
                        "Error. Enter a valid name.");
            }
            Console.WriteLine();
            return name;
        }

        public static int IDEntry()
        {
            int id = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Enter id: ");
                valid = int.TryParse(Console.ReadLine(), out id);
                if (!valid)
                    Console.WriteLine("Error. Please enter a number.");
            }
            return id;
        }

        public static void IDRemoval(Dictionary <int, string> target)
        {
            int id = 0;
            bool exist = false;
            while (!exist)
            {
                id = IDEntry();
                exist = target.ContainsKey(id);
                if (!exist)
                    Console.WriteLine("Unknown ID");
            }
            target.Remove(id);
            Console.WriteLine();
        }
    }
}
