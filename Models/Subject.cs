using P1_AppConsole.Interfaces;
using System.Globalization;

namespace P1_AppConsole.Models
{
    public class Subject : ICredential
    {
        public string? Name { get; set; }
        public int ID { get; set; }

        public void SetID(Campus campus)
        {
            while (ID == default || campus.Students.ContainsKey(ID))
            {
                Random rand = new();
                ID = rand.Next(campus.StudentsCapacity);
            }
        }

        public string? SetName()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("\nError! Enter a valid name.");
                return null;
            }
            return textInfo.ToTitleCase(name.ToLower()).ToString();
        }
    }
}
