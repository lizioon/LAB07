using System;

namespace LAB07
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c) : base("Triangle")
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с такими сторонами не существует!");

            SideA = a;
            SideB = b;
            SideC = c;
            CalculateMetrics();
        }

        private void CalculateMetrics()
        {
            Perimeter = SideA + SideB + SideC;
            double p = Perimeter / 2; 
            Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override string ToString()
        {
            return base.ToString() + $", Стороны = ({SideA}, {SideB}, {SideC})";
        }
    }
}