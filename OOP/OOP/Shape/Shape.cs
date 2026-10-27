using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public abstract class Shape
    {
        public  abstract double Area();

       public void ShowInfo()
     {
            Console.WriteLine($"{GetType().Name}: {Area():F2}");
        }
    }
}
