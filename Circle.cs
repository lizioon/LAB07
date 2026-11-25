using System;

namespace LAB07
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
            CalculateMetrics();
        }

        private void CalculateMetrics()
        {
            Area = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return base.ToString() + $", Радиус = {Radius}";
        }
    }
}