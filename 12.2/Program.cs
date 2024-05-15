using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2
{
    class Shape
    {
        public string Color { get; set; }
        public string Type { get; set; }

        public Shape(string color, string type)
        {
            Color = color;
            Type = type;
        }
    }

    class Square : Shape
    {
        public double SideLength { get; set; }

        public Square(string color, string type, double sideLength) : base(color, type)
        {
            SideLength = sideLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Square square = new Square("Синій", "Квадрат", 5);

            Console.WriteLine($"Колір: {square.Color}");
            Console.WriteLine($"Тип: {square.Type}");
            Console.WriteLine($"Довжина сторони: {square.SideLength}");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
