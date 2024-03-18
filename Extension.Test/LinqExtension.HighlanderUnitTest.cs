using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class HighlanderUnitTest
    {
        private List<int> m_DataList;

        [SetUp]
        public void Setup()
        {
            m_DataList = Enumerable.Range(0, 10).ToList();           
        }

        [Test]
        public void Highlander_WithErrorMessage_ThrowsExceptionWithMessage()
        {
            string message = "user error message";
            Action act = () => m_DataList.Highlander(message);

            act.Should().Throw<InvalidOperationException>().WithMessage("There can only be one MacLeod. " + message);
        }

        [Test]
        public void Highlander_WithFilter_ThrowsExceptionWithMessage()
        {
            string message = "user filter 42 error message";
            Action act = () => m_DataList.Highlander(x => x == 42, message);

            act.Should().Throw<InvalidOperationException>().WithMessage("There can only be one MacLeod. " + message);
        }

        [Test]
        public void Highlander_Get_ReturnElement()
        {
            m_DataList = new List<int>{-896};
            string message = "user error message";

            var returnValue = m_DataList.Highlander(message);
            returnValue.Should().Be(-896);
        }

        [Test]
        public void Highlander_WithFilter_ReturnElement()
        {
            m_DataList = new List<int> { 1518 };
            string message = "user error message";
            var returnValue = m_DataList.Highlander(x => x == 1518, message);

            returnValue.Should().Be(1518);
        }
    }
}