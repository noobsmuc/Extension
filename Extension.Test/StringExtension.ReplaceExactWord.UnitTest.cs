using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class StringReplaceExactWordUnitTest
    {
        const string InputString = "Add Additional String";

        [Test]
        public void ReplaceExactWord_StringToReplace_ReturnStringWithTheReplacedWord()
        {
            InputString.ReplaceExactWord("Add", "Insert").Should().Be("Insert Additional String") ;
        }
    }
}