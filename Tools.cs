namespace P1_AppConsole
{
    public abstract class Tools
    {
        public static string NameCheck(string name)
        {
            while (String.IsNullOrEmpty(name))
            {
                name = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(name))
                    Console.WriteLine(
                        "Error. Enter a valid name.");
            }
            return name;
        }
    }
}
