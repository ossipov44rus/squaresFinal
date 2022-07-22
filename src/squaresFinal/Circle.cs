namespace squaresFinal
{
    public class Circle : ISquareable
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
}