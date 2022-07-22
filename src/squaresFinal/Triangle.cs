namespace squaresFinal;

public class Triangle : ISquareable
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double P => (_a + _b + _c) / 2;
        public double Square()
        {
            if (_a > 0 && _b > 0 && _c > 0)
            {
                var square = Math.Sqrt(P * (P - _a) * (P - _b) * (P - _c));
                return square;
            }
            else
            {
                throw new ArgumentException("All sides of the triangle have to be greater than 0");
            }
        }

        public bool IsRightTriangle()
        {
            if (_a > 0 && _b > 0 && _c > 0)
            {
                var biggest = 0D;
                var allSides = new List<double>() { _a, _b, _c };
                foreach (var i in allSides)
                {
                    if (i > biggest)
                    {
                        biggest = i;
                    }
                }

                allSides.Remove(biggest);
                var hypotenuse = Math.Pow(biggest, 2);
                var catet1 = Math.Pow(allSides[0], 2);
                var catet2 = Math.Pow(allSides[1], 2);
                if (hypotenuse == catet2 + catet1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException("All sides of the triangle have to be greater than 0");
            }
        }

    }
