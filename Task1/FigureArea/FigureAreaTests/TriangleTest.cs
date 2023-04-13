using FigureArea.Implementation;

namespace FigureAreaTests
{
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase(16, 6, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -1)]
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]     
        public void Triangle_WrongSidesTest__ShouldGetException(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 5, ExpectedResult = 6d)]
        [TestCase(6, 8, 10, ExpectedResult = 24d)]
        public double Triangle_SquareTest__ShouldReturnCorrectResult(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var square = triangle.GetSquare();

            return square;
        }

        [TestCase(2, 3, 4, ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5.1, ExpectedResult = false)]
        public bool Triangle_IsRightTriangle_ShouldReturnCorrectResult(double a, double b, double c)
        {            
            var triangle = new Triangle(a, b, c);
            
            var isRight = triangle.IsRightTriangle();
            
            return isRight;
        }
    }
}