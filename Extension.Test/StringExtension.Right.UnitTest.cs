using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class StringRightUnitTest
    {
        const string InputString = "ThisIsVeryVeryLongText";

        [Test]
        public void Right_Length4_Last4Characters()
        {
            InputString.Right(4).Should().Be("Text"); ;
        }

        [Test]
        public void Right_NegativeLength1_ReturnsEmpytString()
        {
            InputString.Right(-1).Should().BeEmpty();
        }

        [Test]
        public void Right_Length0_ReturnsEmpytString()
        {
            InputString.Right(0).Should().BeEmpty();
        }

        [Test]
        public void Right_GreatherLengthThanString_ReturnsCompleteString()
        {
            InputString.Right(100).Should().Be("ThisIsVeryVeryLongText");
        }

        [Test]
        public void Right_EmptyString_ReturnsCompleteString()
        {
            string input = string.Empty;
            input.Right(100).Should().BeEmpty();
        }
    }
}