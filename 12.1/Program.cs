using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public override double Area()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding  = Encoding.Unicode;

            Circle circle = new Circle(5);
            Console.WriteLine($"Площа круга: {circle.Area()}");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Площа прямокутника: {rectangle.Area()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площа трикутника: {triangle.Area()}");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
