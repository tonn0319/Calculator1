using Calculator1.Classes;

namespace Calculator1.Test.Unit
{
    public class TestCalculator1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            var uut = new Classes.Calculator1();

            Assert.That(uut.Add(5,5), Is.EqualTo(10));
        }
        
        [Test]
        public void SubtractTest()
        {
            var uut = new Classes.Calculator1();

            Assert.That(uut.Subtract(10, 5), Is.EqualTo(5));
        }
        
        [Test]
        public void MultipleTest()
        {
            var uut = new Classes.Calculator1();

            Assert.That(uut.Multiply(5, 5), Is.EqualTo(25));
        }
        
        [Test]
        public void PowerTest()
        {
            var uut = new Classes.Calculator1();

            Assert.That(uut.Power(2, 2), Is.EqualTo(4));
        }







    }
}