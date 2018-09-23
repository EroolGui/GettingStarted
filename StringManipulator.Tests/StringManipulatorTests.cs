using NUnit.Framework;
using StringManipulator;

namespace StringManipulator.Tests
{
    [TestFixture]
    public class StringManipulatorTests
    {
        StringManipulator sut = new StringManipulator();
        [Test]
        public void ShouldRevertString()
        {
            var result = sut.Revert("abcd");
            Assert.That(result, Is.EqualTo("dcba"));
        }
        [TestCase("aBCD", "Abcd")]
        [TestCase("", "")]
        [TestCase("123", "123")]
        [TestCase("@//ТеСТ", "@//тест")]
        public void ShouldFixCaps(string test, string expected)
        {
            var result = sut.CapsFix(test);
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}
