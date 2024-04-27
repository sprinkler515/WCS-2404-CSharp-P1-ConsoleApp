namespace P1_AppConsole
{
    public class Campus
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        protected int MaxSubjectsCount { get; set; }
        protected int MaxStudentsCapacity { get; set; }

        public Campus()
        {
            Students = [];
            Subjects = [];
            MaxSubjectsCount = 100;
            MaxStudentsCapacity = 1000;
        }

        public void CheckStudent()
        {
            bool valid;

            Console.Write("Enter id: ");
            valid = int.TryParse(Console.ReadLine(), out int id);

            if (!valid)
                Console.WriteLine("Error! Enter a valid number.");
            else
            {
                id = SearchStudent(id);
                if (id == -1)
                    Console.WriteLine("Student not found.");
                else
                    DisplayStudent(Students[id]);
            }
        }

        public int SearchStudent(int id)
        {
            int index = -1;

            for (int i = 0; i < Students.Count; i++)
                if (id == Students[i].ID)
                    index = i;

            return index;
        }

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
                Console.WriteLine($"\tSubject : ");
                Console.WriteLine($"\t\tScore : ");
                Console.WriteLine($"\t\tEvaluation : ");
            }

            Console.WriteLine($"\tAverage : ");

            for (int i = 0; i < charCnt; i++)
                Console.Write('-');
            Console.WriteLine();
        }

        public void DisplayStudents()
        {
            foreach (Student student in Students)
                Console.WriteLine($"#{student.ID}\t: {student.LastName} {student.FirstName}");
            Console.WriteLine();
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
