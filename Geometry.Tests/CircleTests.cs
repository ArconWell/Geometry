namespace Geometry.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-10)]
        [InlineData(0)]
        public void Constructor_with_invalid_radius_should_throw_exception(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, 3.14)]
        [InlineData(2, 12.56)]
        public void GetArea_should_return_correct_area(double radius, double expectedArea)
        {
           Circle circle = new Circle(radius);
           Assert.Equal(expectedArea, circle.GetArea(), 0.01);
        }
    }
}