using System;

namespace Factory_Pattern
{
    public interface Shape
    {
        void Draw();
    }

    public class Circle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw Method\n");
        }
    }

    public class Sqaure:Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw Method\n");
        }
    }

    public class Rectangle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw Method\n");
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            shapeType = shapeType.ToUpper();
            if (shapeType == null)
                return null;

            if (shapeType == "CIRCLE")
                return new Circle();
            else if (shapeType == "SQUARE")
                return new Sqaure();
            else if (shapeType == "RECTANGLE")
                return new Rectangle();
            return null;
        }
    }

    class FactoryPatternDemo
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Shape shape = shapeFactory.GetShape("circle");
            shape.Draw();

            shape = shapeFactory.GetShape("square");
            shape.Draw();

            shape = shapeFactory.GetShape("rectangle");
            shape.Draw();
        }
    }
}
