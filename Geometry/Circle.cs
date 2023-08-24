namespace Geometry
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius > 0 ? radius : throw new ArgumentException("Radius must be positive");
        }

        public override double GetArea()
        {
            if (area == default)
            {
                area = Math.PI * Radius * Radius;
            }
            return area;
        }
    }
}
