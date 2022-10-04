using System;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.Write("Сторона 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.PerimeterCalculator();
            rectangle.AreaCalculator();
            Console.WriteLine($"Периметр = {rectangle.Perimeter}");
            Console.WriteLine($"Площа = {rectangle.Area}");
            Console.ReadLine();
        }
    }
}
