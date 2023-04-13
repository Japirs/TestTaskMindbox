using FigureArea.Implementation;

namespace FigureAreaTests
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_ZeroRadiusTest_ShouldGetException()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void Circle_NegativeRadiusTest_ShouldGetException()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }

        [TestCase(3, ExpectedResult = 9 * Math.PI)]
        [TestCase(2, ExpectedResult = 4 * Math.PI)]
        [TestCase(12, ExpectedResult = 144 * Math.PI)]
        public double Circle_SquareTest_ShouldReturnCorrectResult(double radius)
        {           
            var circle = new Circle(radius);           

            var square = circle.GetSquare();

            return square;
        }
    }
}