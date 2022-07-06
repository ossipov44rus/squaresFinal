using squaresFinal;

namespace TestingCircle
{
    public class Tests
    {
        [Test]
        public void CircleValid()
        {
            var circle = new Circle(1);


            var expected = Math.PI * Math.Pow(1, 2);
            var actual = circle.Square();
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void CircleInvalid()
        {
            var circle = new Circle(-1);


            Assert.Throws<ArgumentException>(() => circle.Square());


        }
    }
}