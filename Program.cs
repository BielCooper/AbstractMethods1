using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractMethods1.Entities;
using AbstractMethods1.Entities.Enums;

namespace AbstractMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            
            Console.Write("Enter the number of Shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char answer = char.Parse(Console.ReadLine());

                if (answer == 'r')
                {
                    Console.Write("Color Black/Blue/Red: ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }

                else
                {
                    Console.Write("Color Black/Blue/Red: ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}