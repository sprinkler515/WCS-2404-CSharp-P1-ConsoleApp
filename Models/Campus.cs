using P1_AppConsole.Features;
using P1_AppConsole.Menus;
using System.Globalization;

namespace P1_AppConsole.Models
{
    public class Campus
    {
        public Management Management { get; set; }
        public SortedDictionary<int, Student> Students { get; set; }
        public SortedDictionary<int, Subject> Subjects { get; set; }
        public int NbSubjects { get; set; }
        public int StudentsCapacity { get; set; }

        public Campus()
        {
            Management = new();
            Students = [];
            Subjects = [];
            NbSubjects = 100;
            StudentsCapacity = 1000;
        }
    }
}
