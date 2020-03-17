using System.Security.Cryptography;
namespace Facade_Pattern
{
    public interface Shape
    {
        string draw();
    }

    public class Square :Shape
    {
        public string draw()
        {
            return "Drawing Square\n";
        }
    }

    public class Rectangle : Shape
    {
        public string draw()
        {
            return "Drawing Rectangle\n";
        }
    }

    public class Circle: Shape
    {
        public string draw()
        {
            return "Drawing Circle";
        }
    }

    public class ShapeMaker
    {
        private Shape square;
        private Shape rectangle;
        private Shape circle;

        public ShapeMaker()
        {
            square = new Square();
            rectangle = new Rectangle();
            circle = new Circle();
        }

        public string DrawSquare()
        {
            return square.draw();
        }

        public string DrawRectangle()
        {
            return rectangle.draw();
        }

        public string DrawCircle()
        {
            return circle.draw();
        }
    }
}