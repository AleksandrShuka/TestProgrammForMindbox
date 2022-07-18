using TestProgrammForMindbox;

namespace UnitTests
{
    public class UnitTestCircle
    {
        [Fact]
        public void TestCircleSquareIntegerRadius()
        {
            var expected = Math.PI;
            var actual = Calculate.CalculateCircleSquare(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCircleSquareDoubleRadius()
        {
            var expected = Math.PI * 1.1 * 1.1;
            var actual = Calculate.CalculateCircleSquare(1.1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCircleSquareZeroRadius()
        {
            var expected = 0;
            var actual = Calculate.CalculateCircleSquare(0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCircleSquareNegativeRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculate.CalculateCircleSquare(-1));
        }
    }
}