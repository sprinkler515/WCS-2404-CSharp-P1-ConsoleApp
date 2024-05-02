using P1_AppConsole.Interfaces;
using System.Globalization;

namespace P1_AppConsole.Models
{
    public class Student : ICredential
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birthdate { get; set; }
        public List<Grade> Grades { get; set; }
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

        public string? SetBirthdate()
        {
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("\nError! Invalid input.");
                return null;
            }
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
