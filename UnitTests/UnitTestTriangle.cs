using TestProgrammForMindbox;


namespace UnitTests
{
    public class UnitTestTriangle
    {
        private const double EPS = 0.1;
        [Fact]
        public void TestTriangleSquareIntegerSides()
        {
            var expected = 0.97;
            var actual = Calculate.CalculateTriangleSquare(1, 2, 2);
            Assert.True(Math.Abs(expected - actual) < EPS);
        }

        [Fact]
        public void TestTriangleSquareDoubleSides()
        {
            var expected = 1.17;
            var actual = Calculate.CalculateTriangleSquare(1.1, 2.2, 2.2);
            Assert.True(Math.Abs(expected - actual) < EPS);
        }

        [Fact]
        public void TestTriangleSquareZeroSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculate.CalculateTriangleSquare(0, 1, 1));
        }

        [Fact]
        public void TestTriangleSquareOneBigSide()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => Calculate.CalculateTriangleSquare(4, 3, 100));
        }

        [Fact]
        public void TestTriangleSquareNegativeSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculate.CalculateTriangleSquare(4, 3, -1));
        }

        [Fact]
        public void TestTriangleIsRightTrue()
        {
            var actual = Calculate.IsRightTriangle(3, 5, 4);
            Assert.True(actual);
        }

        [Fact]
        public void TestTriangleIsRightFalse()
        {
            var actual = Calculate.IsRightTriangle(3, 5, 4.01);
            Assert.False(actual);
        }
    }
}
