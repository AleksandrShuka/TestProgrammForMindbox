namespace TestProgrammForMindbox.data
{
    public class Triangle : ICalculateSquare
    {
        private const double EPS = 0.00001;
        private double[] _sides = new double[3];

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne < 0 || sideTwo < 0 || sideThree < 0)
            {
                throw new ArgumentOutOfRangeException("Sides needs to be positive");
            }

            if (sideOne >= sideTwo + sideThree ||
                sideTwo >= sideOne + sideThree ||
                sideThree >= sideTwo + sideOne)
            {
                throw new ArgumentOutOfRangeException("Uncorrect sides, needs a < b + c");
            }

            _sides[0] = sideOne;
            _sides[1] = sideTwo;
            _sides[2] = sideThree;
        }

        public double CalculateSquare()
        {
            double semiPerimetr = (_sides[0] + _sides[1] + _sides[2]) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - _sides[0]) * (semiPerimetr - _sides[1]) * (semiPerimetr - _sides[2]));
        }

        public bool IsRightTriangle()
        {
            var sidesPower2 = ArrayToPower2(_sides);
            Array.Sort(sidesPower2);
            Array.Reverse(sidesPower2);

            if (Math.Abs(sidesPower2[0] - sidesPower2[1] - sidesPower2[2]) < EPS)
            {
                return true;
            }
            return false;
        }

        private double[] ArrayToPower2(double[] array)
        {
            double[] result = new double[3];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }

            return result;
        }
    }
}
