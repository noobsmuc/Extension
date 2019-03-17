using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class LastUnitTest
    {
        private List<int> m_DataList;

        [SetUp]
        public void Setup()
        {
            m_DataList = Enumerable.Range(0, 10).ToList();           
        }

        [Test]
        public void Last_WithErrorMessage_ThrowsExceptionWithMessage()
        {
            m_DataList = new List<int>();
            string message = "user error message";
            Action act = () => m_DataList.Last(message);

            act.ShouldThrow<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void Last_WithFilter_ThrowsExceptionWithMessage()
        {
            string message = "user filter 66 error message";
            Action act = () => m_DataList.Last(x => x == 66, message);

            act.ShouldThrow<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void Last_Get_ReturnElement()
        {
            string message = "user error message";

            var returnValue = m_DataList.Last(message);
            returnValue.Should().Be(9);
        }

        [Test]
        public void Last_WithFilter_ReturnElement()
        {
            string message = "user error message";
            var returnValue = m_DataList.Last(x => x == 8, message);

            returnValue.Should().Be(8);
        }
    }
}