

namespace StudentDemo;

class Program
{
    static void Main()
    {
    

        try
        {
            List<Student> students = new List<Student>
            {
                new Student("Rishan", "SI-101", 95),
                new Student("Arif", "SI-102", 85),
                new Student("Emon", "SI-103", 65),
                new Student("Naim", "SI-104", 60),
                new Student("Shahed", "SI-105", 75),
                new Student("Nirob", "SI-106", 60),
                new Student("Saif", "SI-107", 75),
                new Student("Alamin", "SI-108", 82),
                new Student("Efad", "SI-109", 85),
                new Student("Akash","SI-110",40),
                new Student("Nehal","SI-111",32),
                new Student("Arian","SI-112",45),
                new Student("Rakesh","SI-113",30),
            };

            // Start LINQ

            // search student
            Console.Write("Enter a student name: ");
            string searchName = Console.ReadLine() ?? "";

            var results = students
                        .Where(s => s.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase))
                        .ToList();

            if (results.Count > 0)
            {
                foreach(var result in results)
                {
                    result.ShowInfo();
                }
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("");

                // maximum marks start
                int maxMarks = students.Max(s => s.Marks);
            var topStudents = students
                             .Where(s => s.Marks ==  maxMarks)
                             .ToList();
            foreach(var s  in topStudents)
            {
                Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Marks : {s.Marks}");
            }
            // maximum marks end

            Console.WriteLine("");

            // marks 80+
            var bigMarks = students.Where(s => s.Marks >= 80).ToList();
            foreach (var bmarks in bigMarks)
            {
                Console.WriteLine($"Id: {bmarks.Id} | Name : {bmarks.Name} | Marks: {bmarks.Marks} ");
            }
            // marks 80+

            Console.WriteLine("");
            var top3 = students
                             .OrderByDescending(s => s.Marks)
                             .ThenBy(s => s.Name)
                             .Take(3);
              foreach(var top in top3)
            {
                Console.WriteLine($"Name : {top.Name} | Marks: {top.Marks}");
            }

            Console.WriteLine("");

            // Avarage Marks

            if (students.Any())
            {
                var average = students.Average(s => s.Marks);
                Console.WriteLine($"Average marks: {average:F2}");
            }
        

            Console.WriteLine("");

            var gradeGroups = students.GroupBy(s => s.Grade);
            foreach(var group in gradeGroups)
            {
                Console.WriteLine($"Grade : {group.Key} : {group.Count()} student");
                foreach(var g in group)
                {
                    Console.WriteLine($"Name: {g.Name} | Marks: {g.Marks} | Grade : {g.Grade}");
                }
            }

            Console.WriteLine("");

            var failStudent = students
                             .Where(s => s.Grade == "F").ToList();
            Console.WriteLine($"Total Faild : {failStudent.Count}");

            foreach(var student in failStudent)
            {
                Console.WriteLine($"Name : {student.Name} | Marks : {student.Marks}");
            }
            
       

        

            // End LINQ

        


            Console.WriteLine("");

            foreach (var student in students)
            {
                student.ShowInfo();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    
    }
}