namespace LAB07
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
            CalculateMetrics();
        }

        private void CalculateMetrics()
        {
            Area = Width * Height;
            Perimeter = 2 * (Width + Height);
        }

        public override string ToString()
        {
            return base.ToString() + $", Ширина = {Width}, Высота = {Height}";
        }
    }
}