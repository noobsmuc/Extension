using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class StringReplaceExactWordUnitTest
    {
        const string InputString = "Add >= Additional < String";

        [Test]
        public void ReplaceExactWord_StringToReplace_ReturnStringWithTheReplacedWord()
        {
            InputString.ReplaceExactWord("Add", "Insert").Should().Be("Insert >= Additional < String");
        }

        [Test]
        public void ReplaceExactWord_StringToReplaceWithXmlSigns_ReturnStringWithTheReplacedWord()
        {
            InputString.ReplaceExactWord(">=", "!=").Should().Be("Add != Additional < String");
        }

        [Test]
        public void ReplaceExactWord_StringToReplaceWithXml_ReturnStringWithTheReplacedWord()
        {
            string act = "<ReplaceMe>ReplaceMeNotHere</ReplaceMe>";

            string result = act.ReplaceExactWord("ReplaceMe", "OtherValue");
                
            result.Should().Be("<OtherValue>ReplaceMeNotHere</OtherValue>");
        }
    }
}