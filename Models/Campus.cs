using P1_AppConsole.Features;

namespace P1_AppConsole.Models
{
    public class Campus
    {
        public Dictionary<int, Student> Students { get; set; }
        public Dictionary<int, Subject> Subjects { get; set; }
        public Feature Feature { get; set; }
        public int NbSubjects { get; set; }
        public int StudentsCapacity { get; set; }

        public Campus()
        {
            Students = [];
            Subjects = [];
            Feature = new();
            NbSubjects = 100;
            StudentsCapacity = 1000;
        }
    }
}
