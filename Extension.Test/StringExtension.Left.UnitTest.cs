using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class StringLeftUnitTest
    {
        const string InputString = "ThisIsVeryVeryLongText";

        [Test]
        public void Left_Length4_First4Characters()
        {
            InputString.Left(4).Should().Be("This"); ;
        }

        [Test]
        public void Left_NegativeLength1_ReturnsEmpytString()
        {
            InputString.Left(-1).Should().BeEmpty();
        }

        [Test]
        public void Left_Length0_ReturnsEmpytString()
        {
            InputString.Left(0).Should().BeEmpty();
        }

        [Test]
        public void Left_GreatherLengthThanString_ReturnsCompleteString()
        {
            InputString.Left(100).Should().Be("ThisIsVeryVeryLongText");
        }

        [Test]
        public void Left_EmptyString_ReturnsCompleteString()
        {
            string input = string.Empty;
            input.Left(100).Should().BeEmpty();
        }
    }
}