using NUnit.Framework;
using FizzBuzz.Service;

namespace FizzBuzz.UnitTests.Service
{
    [TestFixture]
    public class FizzBuzzService_ConvertShould
    {
        private readonly FizzBuzzService _fizzbuzzService;

        public FizzBuzzService_ConvertShould()
        {
            _fizzbuzzService = new FizzBuzzService();
        }

        [Test]
        public void ReturnOneWhenGivenValueOfOne()
        {
            var one = _fizzbuzzService.Convert(1);
            Assert.AreEqual("1", one);
        }
    }
}