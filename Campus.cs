using P1_AppConsole.Menus;
using System.Runtime.InteropServices;

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

        // Students
        // 1. List all students
        public void DisplayStudents()
        {
            foreach (KeyValuePair<int, Student> student in Students)
                Console.WriteLine($"#{student.Key}\t: {student.Value.LastName} {student.Value.FirstName}");
            Console.WriteLine();
        }

        // 2. Create new student
        public void CreateStudent()
        {
            Student student = new();
            // Unique ID
            while (Students.ContainsKey(student.ID))
            {
                Random rand = new();
                student.ID = rand.Next(StudentsCapacity);
            }

            // - Set FirstName
            Console.Write("Enter lastname: ");
            student.LastName = SetName();

            // - Set LastName
            Console.Write("Enter firstname: ");
            student.FirstName = SetName();

            // - Set Birthdate
            Console.Write("Enter birthdate (MM/DD/YYYY): ");
            // To do
            student.Birthdate = Console.ReadLine() ?? "";

            Students.Add(student.ID, student);
        }

        // 3. Consult Student
        public void ConsultStudent()
        {
        // - Check Student
            int id = SearchStudentByID();
        // - Display student
            Students[id].DisplayStudent();
        }

        // 4. Add grade
        public void AddGrade()
        {
            Grade grade = new();
            int studentID, subjectID;

            // Search student ID
            studentID = SearchStudentByID();

            // Search subject ID
            subjectID = SearchSubjectByID();

            // Add subject to grade
            grade.SubjectName = Subjects[subjectID];

            // Add score
            grade.SetScore();

            // Add evaluation
            grade.SetEvaluation();

            // Add grade to Grades
            Students[studentID].Grades.Add(grade);
        }

        public int SearchStudentByID()
        {
            Console.Write("Enter student ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Students.TryGetValue(id, out _))
                    return id;
            return default;
        }

        public int SearchSubjectByID()
        {
            Console.Write("Enter subject ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Subjects.TryGetValue(id, out _))
                    return id;
            return default;
        }

        public static string SetName()
        {
            string name;

            name = Console.ReadLine() ?? "";
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error!\nEnter a valid name: ");
                name = Console.ReadLine() ?? "";
            }
            return name;
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
                {
                    Console.WriteLine("Success");
                }
                else
                    Console.WriteLine($"No subjects with ID#{id} has been found.");
        }
    }
}

