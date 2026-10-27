namespace Student;

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
                new Student("Saif", "SI-106", 75),
                new Student("Alamin", "SI-107", 82),
                new Student("Efad", "SI-108", 85),
            };

            // Start LINQ

            // maximum marks
            int maxMarks = students.Max(s => s.Marks);
            var topStudents = students
                             .Where(s => s.Marks ==  maxMarks)
                             .ToList();
            foreach(var s  in topStudents)
            {
                Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Marks : {s.Marks}");
            }
            // maximum marks

            Console.WriteLine("");

            // marks 80+
            var bigMarks = students.Where(s => s.Marks >= 80).ToList();
            foreach (var bmarks in bigMarks)
            {
                Console.WriteLine($"Id: {bmarks.Id} | Name : {bmarks.Name} | Marks: {bmarks.Marks} ");
            }
            // marks 80+

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