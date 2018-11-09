using System;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathUnitTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ShouldReturnTheSumOfTwoArguments()
        {

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int firstNum, int secondNum, int expectedResult)
        {
            var result = _math.Max(firstNum, secondNum);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            
            
            // this just checks if the elements are in the collection
            Assert.That(result, Is.EquivalentTo(new int[] { 1, 5, 3 }));
            
            // this is sorted
            Assert.That(result, Is.Ordered);
        }

        [Test]
        public void GetOddNumbers_LimitEqualsZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.EquivalentTo(new int[] {}));
        }

        [Test]
        public void GetOddNumbers_LimitLessThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(-2);

            Assert.That(result, Is.EquivalentTo(new int[] { }));
        }

        [Test]
        [Ignore("Example of ignored test.")]
        public void IgonredTest()
        {

        }
    }
}
