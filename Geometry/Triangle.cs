namespace Geometry
{
    public class Triangle : Figure
    {
        public List<double> Sides { get; }
        private bool? isTriangleRight;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("The triangle doesn't exist.\nThe sum of each two sides of the triangle must be greater than the third");
            }

            Sides = new List<double>() { side1, side2, side3 };
        }

        public override double GetArea()
        {
            if (area == default)
            {
                double p = Sides.Sum() / 2;
                area = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
            return area;
        }

        public bool IsTriangleRight()
        {
            if (isTriangleRight is null)
            {
                List<double> sortedSides = new List<double>(Sides);
                sortedSides.Sort();
                isTriangleRight = Math.Pow(sortedSides[2], 2) == Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2);
            }
            return (bool)isTriangleRight;
        }
    }
}
