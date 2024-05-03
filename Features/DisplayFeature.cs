using P1_AppConsole.Interfaces;
using P1_AppConsole.Models;

namespace P1_AppConsole.Features
{
    public class DisplayFeature : IDisplay, ILog
    {
        public void Display(Student student)
        {
            double average;

            Console.WriteLine("\nStudents information :\n");
            StudentCard(student);
            Console.WriteLine("\nScores:\n");

            foreach (Grade grade in student.Grades)
            {
                if (grade.SubjectName is not null)
                    Console.WriteLine($"\tSubject : {grade.SubjectName.Name}");
                Console.WriteLine($"\t{String.Empty,5}Score : {grade.Score}/20");
                Console.WriteLine($"\t{String.Empty,5}Evaluation : {grade.Evaluation}\n");
            }
            average = Math.Round(student.CalcAverage() * 2, MidpointRounding.AwayFromZero) / 2;
            Console.WriteLine($"\tAverage : {average}");
            SaveLog($"View student informations : #{student.ID} {student.FirstName} {student.LastName}");
        }

        public void Display(SortedDictionary<int, Student> students)
        {
            Header();
            Console.WriteLine("List of students :\n");
            foreach (KeyValuePair<int, Student> student in students)
                Console.WriteLine($"#{student.Key}\t: {student.Value.FirstName} {student.Value.LastName}");
            Footer();
        }

        public void Display(SortedDictionary<int, Subject> subjects)
        {
            Header();
            Console.WriteLine("List of subjects :\n");
            foreach (KeyValuePair<int, Subject> subject in subjects)
                Console.WriteLine($"#{subject.Key}\t: {subject.Value.Name}");
            Footer();
        }

        public void Check(Campus campus)
        {
            SearchFeature search = campus.Management.SearchFeature;
            Student student;

            Display(campus.Students);
            int id = search.SearchID(campus.Students);
            if (id == default)
            {
                Console.WriteLine("\nError! Student doesn't exist.");
                Footer();
                return;
            }
            student = campus.Students[id];
            Header();
            Display(student);
            Footer();
            SaveLog($"View student : #{id} {student.FirstName} {student.LastName}");
        }

        public void StudentCard(Student student)
        {
            Console.WriteLine($"Student ID\t# {student.ID}\n");
            Console.WriteLine($"First name\t: {student.FirstName}");
            Console.WriteLine($"Last name\t: {student.LastName}");
            Console.WriteLine($"Birthdate\t: {student.Birthdate}");
        }

        public void Control()
        {
            Console.Write("Press return to continue...");
            Console.ReadLine();
        }

        public void Header()
        {
            Console.Clear();
            Separator();
            Console.WriteLine();
        }

        public void Footer()
        {
            Console.WriteLine();
            Separator();
            Console.WriteLine('\n');
        }

        public void Separator()
        {
            int len = 70;
            for (int i = 0; i < len; i++)
                Console.Write("-");
        }

        public void SaveLog(string entry)
        {
            string log = $"{DateTime.Now} - {entry}\n";
            File.AppendAllText("campus.txt", log);
        }
    }
}
