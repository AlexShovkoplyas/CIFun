using App;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        private Calculator _subject;

        [SetUp]
        public void Setup()
        {
            _subject = new Calculator();
        }

        [Test]
        public void Add()
        {
            var result = _subject.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Divide()
        {
            var result = _subject.Divide(6, 2);
            Assert.That(result, Is.EqualTo(3));
        }


    }
}