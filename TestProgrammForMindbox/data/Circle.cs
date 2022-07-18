namespace TestProgrammForMindbox.data
{
    public class Circle : ICalculateSquare
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0) {
                throw new ArgumentOutOfRangeException("Radius needs to be positive");
            }
            _radius = radius;
        }

        public double CalculateSquare()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
