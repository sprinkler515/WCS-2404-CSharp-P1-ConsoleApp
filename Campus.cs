using System.ComponentModel.Design;

namespace P1_AppConsole
{
    public class Campus
    {
        public Dictionary<int, Student> Students;
        public Dictionary<int, string> Subjects;

        public Campus()
        {
            Students = [];
            Subjects = [];
        }

        public void DisplayStudents()
        {
            foreach (KeyValuePair<int, Student> student in Students)
                Console.WriteLine($"#{student.Key}\t: {student.Value}");
            Console.WriteLine();
        }

        public void DisplaySubjects()
        {
            foreach(KeyValuePair<int,string> subject in Subjects)
                Console.WriteLine($"{subject.Key} {subject.Value}");
            Console.WriteLine();
        }
    }
}
