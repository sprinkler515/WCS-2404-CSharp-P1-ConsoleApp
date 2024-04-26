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
            bool valid;

            Console.Write("Enter id: ");
            valid = int.TryParse(Console.ReadLine(), out int id);
            if (!valid)
                Console.WriteLine("Error. Please enter a number.");
            return id;
        }

        public static void IDRemoval(Dictionary<int, string> target)
        {
            int id = IDEntry();
            if (!target.ContainsKey(id))
                Console.WriteLine("Unknown ID");
            else target.Remove(id);
            Console.WriteLine();
        }
    }
}
