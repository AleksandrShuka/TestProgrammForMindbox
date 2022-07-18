using TestProgrammForMindbox.data;

namespace TestProgrammForMindbox
{
    public class Calculate
    {
        private Calculate() { }
        public static double CalculateCircleSquare(double radius)
        {
            var circle = new Circle(radius);
            return circle.CalculateSquare();
        }

        public static double CalculateTriangleSquare(double sideOne, double sideTwo, double sideThree)
        {
            var trinagle = new Triangle(sideOne, sideTwo, sideThree);
            return trinagle.CalculateSquare();
        }

        public static double CalculateSquare(ICalculateSquare entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return entity.CalculateSquare();
        }

        public static bool IsRightTriangle(double sideOne, double sideTwo, double sideThree)
        {
            var trinagle = new Triangle(sideOne, sideTwo, sideThree);
            return trinagle.IsRightTriangle();
        }
    }
}
