namespace P1_AppConsole
{
    public class Campus
    {
        private string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        protected int MaxSubjectsCount { get; set; }
        protected int MaxStudentsCapacity { get; set; }

        public Campus()
        {
            Name = "Default";
            Students = [];
            Subjects = [];
            MaxSubjectsCount = 100;
            MaxStudentsCapacity = 1000;
        }
        public Campus(string name, int subjectsCount, int studentsCapacity)
        {
            Name = name;
            Students = [];
            Subjects = [];
            MaxSubjectsCount = studentsCapacity;
            MaxStudentsCapacity = subjectsCount;
        }

        /*
        public Student SearchStudent(int id)
        {
            Student student = new();
            bool found = false;

            foreach (Student el in Students)
            {
                if (id == student.ID)
                {
                    student = el;
                    found = true;
                }
            }

            if (!found) { }

        }
        */
        public void DisplayStudent(Student student)
        {
            int charCnt = 70;

            for (int i = 0; i < charCnt; i++) Console.Write('-');
            Console.WriteLine("\nStudents information :\n");

            Console.WriteLine($"Last name\t: {student.LastName}");
            Console.WriteLine($"First name\t: {student.FirstName}");
            Console.WriteLine($"Birthdate\t: {student.Birthdate}\n");

            Console.WriteLine("Scores:");

            foreach (Subject subject in Subjects)
            {
                Console.WriteLine($"Subject : {subject.Name}");
            }

            for (int i = 0; i < charCnt; i++) Console.Write('-');

        }

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
