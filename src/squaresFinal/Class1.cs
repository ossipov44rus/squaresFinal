namespace squaresFinal
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius) => _radius = radius;

        public double Square()
        {
            if (_radius > 0)
            {
                var square = Math.PI * Math.Pow(_radius, 2);
                return square;
            }
            throw new ArgumentException("Radius has to be more than 0.");

        }
    }

    public class Triangle : IFigure
    {

        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double P => (A + B + C) / 2;
        public double Square()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                var square = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                return square;
            }
            else
            {
                throw new ArgumentException("All sides of the triangle have to be greater than 0");
            }
        }

        public bool IsRightTriangle()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                var biggest = 0D;
                var allSides = new List<double>() { A, B, C };
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

    interface IFigure
    {
        double Square();
    }
}