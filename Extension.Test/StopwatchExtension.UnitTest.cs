using System;
using System.Diagnostics;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class StopwatchUnitTest
    {
        readonly Stopwatch m_Stopwatch = new Stopwatch();

        [OneTimeSetUp]
        public void TestSetup()
        {
            m_Stopwatch.Start();
            Thread.Sleep(1500);
            m_Stopwatch.Stop();
        }

        [Test]
        public void Stopwatch_EmptyFormat_ThrowsArgumentException()
        {
            Action act = () => m_Stopwatch.ToFormatedString(string.Empty);
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Stopwatch_WrongFormat_ThrowsFormatException()
        {
            Action act = () => m_Stopwatch.ToFormatedString("wrongFormat");
            act.Should().Throw<FormatException>();
        }

        [Test]
        public void Stopwatch_Format_ReturnsFormatedString()
        {
            m_Stopwatch.ToFormatedString("g").Should().StartWith("0:00:01,");
        }

        [Test]
        public void Stopwatch_FormatOwn_ReturnsFormatedString()
        {
            m_Stopwatch.ToFormatedString(@"mm\:ss\.ff").Should().Be("00:01.50");
        }
    }
}