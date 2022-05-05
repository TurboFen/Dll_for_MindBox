using System;

namespace TestLibrary
{
        public abstract class Figure
        {
            public abstract double Calc_Square();
            public abstract void Print_Info();

        }
        public class Circle : Figure
        {
            private double radius;
            private double result;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override double Calc_Square()
            {
                result = Math.PI * Math.Pow(radius, 2);
                return result;
            }
            public override void Print_Info()
            {
                Console.WriteLine($"Square = {Calc_Square()}");
            }
    }
        public class Triangle : Figure
        {
            private double a;
            private double b;
            private double c;
            private double result;
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public override double Calc_Square()
            {
                double perimeter = (a + b + c) / 2;
                result = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                return result;
            }
            public bool Is_Triangle_Rectangular()
            {
                double param = Math.Max(Math.Max(a, b), c);
                if (param == a) { return Func_For_Rectangular(b, c, a); }
                if (param == b) { return Func_For_Rectangular(a, c, b); }
                if (param == c) { return Func_For_Rectangular(b, a, c); }
                return false;
            }
            private bool Func_For_Rectangular(double a, double b, double c)
            {
                if (c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) { return true; }
                else { return false; }
            }
            
            public override void Print_Info()
            {
                if (Is_Triangle_Rectangular())
                {
                    Console.WriteLine($"Треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine($"Треугольник не прямоугольный");
                }

                Console.WriteLine("Square = {0}", Calc_Square());
            }
        }
}
