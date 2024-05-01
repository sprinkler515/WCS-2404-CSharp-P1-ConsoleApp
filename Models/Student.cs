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

    }
}
