namespace P1_AppConsole
{
    public class Campus
    {
        public List<Student> Students { get; set; } = [];
        public List<Subject> Subjects { get; set; } = [];

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

        public void RemoveSubject()
        {
            int id = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Enter ID subject for removal: ");
                valid = int.TryParse(Console.ReadLine(), out id);
                if (!valid || id < 100 || id > 999)
                    Console.WriteLine("Error! Please enter a valid number");
            }

            foreach (Subject subject in Subjects)
            {
                if (id == subject.ID)
                {
                    Subjects.Remove(subject);
                    break;
                }
                if (subject == Subjects.Last())
                    Console.WriteLine($"No subjects with ID#{id} has been found.");
            }
        }
    }
}
