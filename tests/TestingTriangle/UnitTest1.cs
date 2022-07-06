using squaresFinal;

namespace TestingTriangle
{
    public class TriangleTests
    {


        [Test]
        public void TriangleValid()
        {
            var triangle = new Triangle(3, 4, 5);

            var expected = 6D;
            var actual = triangle.Square();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TriangleInvalid()
        {
            var triangle = new Triangle(0, 4, 5);

            Assert.Throws<ArgumentException>((() => triangle.Square()));
        }

        [Test]
        public void IsRightTriangleValid()
        {
            var triangle = new Triangle(3, 4, 5);

            var expected = true;
            var actual = triangle.IsRightTriangle();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IsRightTriangleInvalid()
        {
            var triangle = new Triangle(0, 4, 5);

            Assert.Throws<ArgumentException>((() => triangle.Square()));
        }
    }
}