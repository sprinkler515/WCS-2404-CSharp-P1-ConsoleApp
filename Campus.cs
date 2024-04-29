using P1_AppConsole.Menus;

namespace P1_AppConsole
{
    public class Campus
    {
        public Dictionary<int, Student> Students { get; set; }
        public Dictionary<int, Subject> Subjects { get; set; }
        protected int NbSubjects { get; set; }
        protected int StudentsCapacity { get; set; }

        public Campus()
        {
            Students = [];
            Subjects = [];
            NbSubjects = 100;
            StudentsCapacity = 1000;
        }

        public void CheckStudent()
        {
            Console.Write("Enter id: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Students.TryGetValue(id, out Student? value))
                    DisplayStudent(value);
                else
                    Console.WriteLine("Student not found.");
            else
                Console.WriteLine("Error! Enter a valid number.");
        }

        public void DisplayStudent(Student student)
        {
            CampusManager.DrawLine();
            Console.WriteLine("\nStudents information :\n");

            Console.WriteLine($"Last name\t: {student.LastName}");
            Console.WriteLine($"First name\t: {student.FirstName}");
            Console.WriteLine($"Birthdate\t: {student.Birthdate}\n");

            Console.WriteLine("Scores:");

            foreach (KeyValuePair<int, Subject> subject in Subjects)
            {
                Console.WriteLine($"\tSubject : ");
                Console.WriteLine($"\t\tScore : ");
                Console.WriteLine($"\t\tEvaluation : ");
            }

            Console.WriteLine($"\tAverage : ");
            CampusManager.DrawLine();
        }

        public void DisplayStudents()
        {
            foreach (KeyValuePair<int, Student> student in Students)
                Console.WriteLine($"#{student.Key}\t: {student.Value.LastName} {student.Value.FirstName}");
            Console.WriteLine();
        }

        public void DisplaySubjects()
        {
            foreach (KeyValuePair<int, Subject> subject in Subjects)
                Console.WriteLine($"#{subject.Key}\t: {subject.Value.Name}");
            Console.WriteLine();
        }

        public void RemoveSubject()
        {
            Console.Write("Enter ID subject for removal: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Subjects.Remove(id))
                    Console.WriteLine("Success");
                else
                    Console.WriteLine($"No subjects with ID#{id} has been found.");
        }
    }
}
