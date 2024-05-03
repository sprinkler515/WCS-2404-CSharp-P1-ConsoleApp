using P1_AppConsole.Models;
using P1_AppConsole.Interfaces;
using Newtonsoft.Json;

namespace P1_AppConsole.Features
{
    public class AddFeature : IControl, IDatabase, ILog
    {
        public void NewStudent(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            bool confirm = false;

            while (!confirm)
            {
                Student student = new();

                student.SetID(campus);

                display.Header();
                Console.WriteLine("New student :");

                // Set firstname
                Console.Write("\nEnter firstname: ");
                student.FirstName = student.SetName(campus);
                if (student.FirstName == null)
                {
                    Console.Write("Register another student (Yes to confirm) : ");
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                Console.Write("Enter lastname: ");
                student.LastName = student.SetName(campus);
                if (student.LastName == null)
                {
                    Console.Write("Register another student (Yes to confirm) : ");
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                //  Set birthdate
                Console.Write("Enter birthdate (MM-DD-YYYY): ");
                student.Birthdate = student.SetBirthdate(campus);
                if (student.Birthdate == null)
                {
                    Console.Write("Register another student (Yes to confirm) : ");
                    if (Continue()) continue;
                    else
                    {
                        display.Footer();
                        return;
                    }
                }
                // Display new student
                display.Header();
                Console.WriteLine("Student information: \n");
                display.Display(student);

                // Control
                if (Save(campus))
                {
                    campus.Students.Add(student.ID, student);
                    SaveJson(campus);
                    SaveLog($"Add new student : {student.FirstName} {student.LastName}");
                }
                Console.Write("Register another student (Yes to confirm) : ");
                if (Continue()) continue;
                confirm = true;
            }
            display.Footer();
        }

        public void NewSubject(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            bool confirm = false;

            while (!confirm)
            {
                Subject subject = new();

                display.Display(campus.Subjects);
                subject.SetID(campus);
                Console.Write("New subject : ");
                subject.Name = subject.SetName(campus);
                foreach (KeyValuePair<int, Subject> el in campus.Subjects)
                {
                    if (el.Value.Name == subject.Name)
                    {
                        Console.WriteLine("Error! Subject's name already taken.");
                        display.Footer();
                        return;
                    }
                }
                if (Save(campus))
                {
                    campus.Subjects.Add(subject.ID, subject);
                    SaveJson(campus);
                    SaveLog($"Add new subject : {subject.Name}");
                }
                Console.Write("Register another subject (Yes to confirm) : ");
                if (Continue()) continue;
                confirm = true;
            }
            display.Footer();
        }

        public void AddStudentGrade(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            SearchFeature search = campus.Management.SearchFeature;
            Grade grade = new();
            int studentID, subjectID;
            string? firstName, lastName;

            display.Header();
            display.Display(campus.Students);
            studentID = search.SearchID(campus.Students);
            if (studentID == default)
            {
                Console.WriteLine("\nError! Student doesn't exist.");
                display.Footer();
                return;
            }
            display.Header();
            display.Display(campus.Subjects);
            subjectID = search.SearchID(campus.Subjects);
            if (subjectID == default)
            {
                Console.WriteLine("\nError! Subject doesn't exist.");
                display.Footer();
                return;
            }
            display.Footer();
            grade.SubjectName = campus.Subjects[subjectID];
            grade.SetScore();
            display.Footer();
            grade.SetEvaluation();
            campus.Students[studentID].Grades.Add(grade);
            firstName = campus.Students[studentID].FirstName;
            lastName = campus.Students[studentID].LastName;
            display.Footer();
            SaveJson(campus);
            SaveLog($"Add grade to #{studentID} {firstName} {lastName}");
        }

        public bool Save(Campus campus)
        {
            DisplayFeature display = campus.Management.DisplayFeature;
            string input;

            display.Footer();
            Console.Write("Save (Yes to confirm) : ");
            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
            {
                Console.WriteLine("\nSave Successful.");
                display.Footer();
                return true;
            }
            else
                Console.WriteLine("\nNot registered.");
            display.Footer();

            return false;
        }

        public bool Continue()
        {
            string input;

            input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "y" || input == "ye" || input == "yes")
                return true;
            return false;
        }

        public void SaveJson(Campus campus)
        {
            string json = JsonConvert.SerializeObject(campus);
            File.WriteAllText("campus.json", json);
        }

        public void SaveLog(string entry)
        {
            string log = $"{DateTime.Now} - {entry}\n";
            File.AppendAllText("campus.txt", log);
        }
    }
}
