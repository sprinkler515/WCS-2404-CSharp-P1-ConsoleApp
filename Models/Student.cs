using Newtonsoft.Json;
using P1_AppConsole.Features;
using P1_AppConsole.Interfaces;
using System.Globalization;

namespace P1_AppConsole.Models
{
    public class Student : ICredential
    {
        [JsonIgnore]
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birthdate { get; set; }
        public List<Grade> Grades { get; set; }
        [JsonIgnore]
        public double Average { get; set; }

        public Student()
        {
            Grades = [];
            Average = 0;
        }

        public void SetID(Campus campus)
        {
            while (ID == default || campus.Students.ContainsKey(ID))
            {
                Random rand = new();
                ID = rand.Next(campus.StudentsCapacity);
            }
        }

        public string? SetName(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                display.Footer();
                Console.WriteLine("Error! Enter a valid name.");
                display.Footer();
                return null;
            }
            display.Footer();
            return textInfo.ToTitleCase(name.ToLower()).ToString();
        }

        public string? SetBirthdate(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                display.Footer();
                Console.WriteLine("Error! Invalid input.");
                display.Footer();
                return null;
            }
            display.Footer();
            return date.ToString("D");
        }

        public void CalcAverage()
        {
            foreach (Grade grade in Grades)
                Average += grade.Score;
            Average /= Grades.Count;
        }
    }
}
