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
                new Student("Emon", "SI-103", 75),
                new Student("Naim", "SI-104", 88),
                new Student("Shahed", "SI-105", 75)
            };

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