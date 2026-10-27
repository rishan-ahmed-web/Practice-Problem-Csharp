
namespace Shape;

class Program 
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(10.5,5)
        };

        foreach (Shape shape in shapes)
        {
           shape.ShowInfo();
        }

    }
    
}

