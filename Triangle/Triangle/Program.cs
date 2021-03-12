using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static Triangle GetTriangle()
        {
            Triangle triangle;
            bool triangle_flag = false;
            do
            {
                int dot_count = 3;
                Dot[] dots = new Dot[dot_count];

                for (int i = 0; i < dots.Length; i++)
                {
                    Console.WriteLine($"Введите координату x точки №{i + 1}:");
                    double x = GetDouble();
                    Console.WriteLine($"Введите координату y точки №{i + 1}:");
                    double y = GetDouble();
                    dots[i] = new Dot(x, y);
                }
                foreach (var d in dots)
                {
                    Console.WriteLine($"({d.X}, {d.Y})");
                }

                triangle = new Triangle(dots[0], dots[1], dots[2]);
                if (triangle.IsValid())
                    triangle_flag = true;
                else
                {
                    Console.WriteLine("Вы ввели вырожденный треугольник, try next time.");
                }
            }
            while (!triangle_flag);
            return triangle;
        }
        static double GetDouble()
        {
            FormatterResult<double> res = null;
            do
            {
                string inp = Console.ReadLine();
                res = StringFormatter.GetDouble(inp);

                if (res.IsValid)
                {
                    Console.WriteLine("Нармальна!");
                }
                else
                {
                    Console.WriteLine("Ашыпки:");
                    foreach (var s in res.Errors)
                    {
                        Console.WriteLine($"- {s.Message}");
                    }
                }
            }
            while (!res.IsValid);

            return (double)res.Value;
        }



        static void Main(string[] args)
        {

            Triangle triangle = GetTriangle();
            Console.WriteLine("Perimetr = {0}", triangle.Perimeter());
            Console.WriteLine("Area = {0}", triangle.Area());


            Console.ReadKey();



            Console.ReadKey();
        }
    }
}
