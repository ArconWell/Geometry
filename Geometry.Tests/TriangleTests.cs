namespace Geometry.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-10, 2, 5)]
        [InlineData(0, 2, 5)]
        [InlineData(1, 1, 2)]
        public void Constructor_with_invalid_sides_should_throw_exception(double side1, double side2, double side3)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(3.5, 2.8, 2.1, 2.94)]
        public void GetArea_should_return_correct_area(double side1, double side2, double side3, double expectedArea)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.Equal(expectedArea, triangle.GetArea(), 0.01);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(3, 4, 6, false)]
        public void IsTriangleRight_should_return_correct_type(double side1, double side2, double side3, bool expectedType)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.Equal(expectedType, triangle.IsTriangleRight());
        }
    }
}
