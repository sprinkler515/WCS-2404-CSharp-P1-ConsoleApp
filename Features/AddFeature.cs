using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class AddFeature
    {
        public void CreateStudent(Campus campus)
        {
            Student student = new();
            bool confirm = false;

            // Unique ID
            while (student.ID == default || campus.Students.ContainsKey(student.ID))
            {
                Random rand = new();
                student.ID = rand.Next(campus.StudentsCapacity);
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
                Console.WriteLine("Data input : ");
                Console.WriteLine($"Firstname \t:{student.FirstName}");
                Console.WriteLine($"Lastname \t:{student.LastName}");
                Console.WriteLine($"Birthdate \t:{student.Birthdate}\n");

                Console.Write("Confirm (Y/N) :");
                string input = Console.ReadLine() ?? "";
                if (char.TryParse(input.ToLower(), out char chr))
                    confirm = chr == 'y';
            }

            campus.Students.Add(student.ID, student);
        }

        public void CreateSubject(Campus campus)
        {
            Subject subject = new();
            Dictionary<int, Subject> subjects = campus.Subjects;

            // Unique ID
            while (subject.ID == default || subjects.ContainsKey(subject.ID))
            {
                Random rand = new();
                subject.ID = rand.Next(campus.StudentsCapacity);
            }

            // Name
            Console.Write("Enter subject's name: ");
            subject.Name = SetName();

            // Add subject to Subjects
            subjects.Add(subject.ID, subject);
        }


        public void AddGrade(Campus campus)
        {
            Grade grade = new();
            Feature Feature = campus.Feature;
            int studentID, subjectID;

            // Search student ID
            studentID = Feature.SearchFeature.SearchByID(campus.Students);
            Console.WriteLine(studentID);

            // Search subject ID
            subjectID = Feature.SearchFeature.SearchByID(campus.Subjects);

            // Add subject to grade
            grade.SubjectName = campus.Subjects[subjectID];

            // Add score
            grade.SetScore();

            // Add evaluation
            grade.SetEvaluation();

            // Add grade to Grades
            campus.Students[studentID].Grades.Add(grade);
        }

        public static string? SetName()
        {
            string name;

            name = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error! Enter a valid name.\n");
                return null;
            }
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
