using System.Globalization;
using System.Text.RegularExpressions;

namespace P1_AppConsole.Models
{
    public partial class Campus
    {
        public Dictionary<int, Student> Students { get; set; }
        public Dictionary<int, Subject> Subjects { get; set; }
        public int NbSubjects { get; set; }
        public int StudentsCapacity { get; set; }

        public Campus()
        {
            Students = [];
            Subjects = [];
            NbSubjects = 100;
            StudentsCapacity = 1000;
        }

        // Student
        // 1. List students
        public void DisplayStudents()
        {
            foreach (KeyValuePair<int, Student> student in Students)
                Console.WriteLine($"#{student.Key}\t: {student.Value.LastName} {student.Value.FirstName}");
            Console.WriteLine();
        }

        // 2. Add new student
        public void CreateStudent()
        {
            Student student = new();
            bool confirm = false;

            // Unique ID
            while (student.ID == default || Students.ContainsKey(student.ID))
            {
                Random rand = new();
                student.ID = rand.Next(StudentsCapacity);
            }

            while (!confirm)
            {
                // - Set LastName
                Console.Write("Enter firstname: ");
                student.FirstName = SetName();
                if (student.FirstName == null)
                    return;
                Console.WriteLine();

                // - Set FirstName
                Console.Write("Enter lastname: ");
                student.LastName = SetName();
                if (student.LastName == null)
                    return;
                Console.WriteLine();

                // - Set Birthdate
                Console.Write("Enter birthdate (MM-DD-YYYY): ");
                student.Birthdate = SetDate();
                if (student.Birthdate == null)
                    return;
                Console.WriteLine();

                // Recap
                Console.WriteLine("Data input : \n");
                student.Informations();
                Console.Write("Confirm (Y/N) :");
                string input = Console.ReadLine() ?? "";
                if (char.TryParse(input.ToLower(), out char chr))
                    confirm = chr == 'y';
            }
            Students.Add(student.ID, student);
        }

        // 3. Consult student
        public void ConsultStudent()
        {
            // - Check Student
            int id = SearchStudentID();
            // - Display student
            Students[id].Display();
        }

        // 4. Add grade
        public void AddStudentGrade()
        {
            Grade grade = new();
            int studentID, subjectID;

            // Search student ID
            studentID = SearchStudentID();
            Console.WriteLine(studentID);

            // Search subject ID
            subjectID = SearchSubjectID();

            // Add subject to grade
            grade.SubjectName = Subjects[subjectID];

            // Add score
            grade.SetScore();

            // Add evaluation
            grade.SetEvaluation();

            // Add grade to Grades
            Students[studentID].Grades.Add(grade);
        }

        // Subject
        // 1. List subjects
        public void DisplaySubjects()
        {
            foreach (KeyValuePair<int, Subject> subject in Subjects)
                Console.WriteLine($"#{subject.Key}\t: {subject.Value.Name}");
            Console.WriteLine();
        }

        // 2. Add new subject
        public void CreateSubject()
        {
            Subject subject = new();

            // Unique ID
            while (subject.ID == default || Subjects.ContainsKey(subject.ID))
            {
                Random rand = new();
                subject.ID = rand.Next(StudentsCapacity);
            }

            // Name
            Console.Write("Enter subject's name: ");
            subject.Name = SetName();

            // Add subject to Subjects
            Subjects.Add(subject.ID, subject);
        }

        // 3. Remove subject w/ id
        public void RemoveSubject()
        {
            // Search subject by ID
            int id = SearchSubjectID();
            if (!Subjects.Remove(id))
                Console.WriteLine($"Error! Subject #{id}'s not found.");
        }

        // Search features
        public int SearchStudentID()
        {
            Console.Write("Enter student ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Students.TryGetValue(id, out _))
                    return id;
            return default;
        }

        public int SearchSubjectID()
        {
            Console.Write("Enter subject ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                if (Subjects.TryGetValue(id, out _))
                    return id;
            return default;
        }

        // Static methods
        private static string? SetName()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error! Enter a valid name.\n");
                return null;
            }
            name = name.ToLower();
            name = textInfo.ToTitleCase(name).ToString();

            return name;
        }

        private static string? SetDate()
        {
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Error! Invalid input.");
                return null;
            }
            return date.ToString("D");
        }
    }
}
