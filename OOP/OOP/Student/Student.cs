using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace StudentDemo
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
        public string Grade
        {
            get

            {

                if (Marks >= 80)
                    return "A+";
                else if (Marks >= 70)
                    return "A";
                else if (Marks >= 60)
                    return "A-";
                else if (Marks >= 50)
                    return "B";
                else if (Marks >= 40)
                    return "C";
                else if (Marks >= 33)
                    return "D";
                else
                    return "F";

            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} | ID : {Id} | Marks: {Marks} | Grade : {Grade}");
        }
   }
}
