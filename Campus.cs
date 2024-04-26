namespace P1_AppConsole
{
    public class Campus(string name)
    {
        private string Name { get; set; } = name;

        protected List<Student> Students { get; set; } = [];
        protected List<Subject> Subjects { get; set; } = [];

        /*
        public void DisplayStudent()
        {
            foreach (Student student in Students)
                Console.WriteLine($"#{student.ID}\t: {student.}");
            Console.WriteLine();
        }
        */

        public void DisplaySubjects()
        {
            foreach (Subject subject in Subjects)
                Console.WriteLine($"#{subject.ID}\t: {subject.Name}");
            Console.WriteLine();
        }
    }
}
