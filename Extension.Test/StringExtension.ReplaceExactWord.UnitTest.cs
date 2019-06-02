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
        public void ReplaceExactWord_StringToReplaceWithXmlSigns_ReturnStringNotChanged()
        {
            InputString.ReplaceExactWord(">=", "!=").Should().Be("Add >= Additional < String");
        }

        [Test]
        public void ReplaceExactWord_StringToReplaceWithXmlSignsInWord_ReturnStringWithTheReplacedWord()
        {
            "Add >= Additonal a>=w32 String"
                .ReplaceExactWord("a>=w32", "b!ds§").
                Should().Be("Add >= Additonal b!ds§ String");
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