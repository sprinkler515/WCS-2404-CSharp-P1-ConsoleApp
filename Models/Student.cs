using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace P1_AppConsole.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Birthdate { get; set; }
        public List<Grade> Grades { get; set; }
        private double Average { get; set; }

        public Student()
        {
            Grades = [];
        }
        public void Display()
        {
            Console.WriteLine("\nStudents information :\n");
            Informations();
            Console.WriteLine("Scores:");

            foreach (Grade grade in Grades)
            {
                Console.WriteLine($"\tSubject : {grade.SubjectName}");
                Console.WriteLine($"\t\tScore : {grade.Score}");
                Console.WriteLine($"\t\tEvaluation : {grade.Evaluation}");
            }

            Console.WriteLine($"\tAverage : ");
        }

        public void Informations()
        {
            Console.WriteLine($"Last name\t: {LastName}");
            Console.WriteLine($"First name\t: {FirstName}");
            Console.WriteLine($"Birthdate\t: {Birthdate}\n");
        }
    }
}
