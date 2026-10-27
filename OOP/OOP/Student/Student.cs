using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; }
        public int Marks { get; private set; }

        public Student(string name, string id, int marks)
        {
            Name = name;
            Id = id;

            if(marks < 0 || marks > 100 )
                throw new ArgumentException("Marks must be between 0 and 100");
            Marks = marks;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} | ID : {Id} | Marks: {Marks}");
        }
   }
}
