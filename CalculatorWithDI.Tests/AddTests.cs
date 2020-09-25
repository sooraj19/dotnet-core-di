using NSubstitute;
using NUnit.Framework;
using CalculatorWithDI;

namespace CalculatorWithDI.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void AddTwoNumbersWithMockDependency()
        {
            // create mock
            var calcMock = Substitute.For<ICalculator>();

            // setup the mock
            calcMock.Add(1, 3).Returns(15); // it is not, but still to test the mock

            //use the mock
            var calcConsumer = new Consumer(calcMock);
            var result = calcConsumer.ConsumerAdd(1, 3);
            Assert.AreEqual(15, result, "Oops mock didn't work..");
        }
    }
}