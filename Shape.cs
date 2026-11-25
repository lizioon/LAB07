using System;

namespace LAB07
{
    public class Shape
    {
        public string ShapeName { get; set; }
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }

        public Shape(string name)
        {
            ShapeName = name;
        }

        public virtual double GetArea()
        {
            return Area;
        }

        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public override string ToString()
        {
            return $"{ShapeName}: Площадь = {Area:F2}, Периметр = {Perimeter:F2}";
        }

        public static bool operator >(Shape s1, Shape s2)
        {
            return s1.GetArea() > s2.GetArea();
        }

        public static bool operator <(Shape s1, Shape s2)
        {
            return s1.GetArea() < s2.GetArea();
        }

        public static bool operator ==(Shape s1, Shape s2)
        {
            if (ReferenceEquals(s1, s2)) return true;
            if (s1 is null || s2 is null) return false;
            return Math.Abs(s1.GetArea() - s2.GetArea()) < 0.0001; 
        }

        public static bool operator !=(Shape s1, Shape s2)
        {
            return !(s1 == s2);
        }

        
        public override bool Equals(object obj)
        {
            return obj is Shape shape && this == shape;
        }

        public override int GetHashCode()
        {
            return GetArea().GetHashCode();
        }
    }
}