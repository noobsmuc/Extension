using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class FirstUnitTest
    {
        private List<int> m_DataList;

        [SetUp]
        public void Setup()
        {
            m_DataList = Enumerable.Range(0, 10).ToList();           
        }

        [Test]
        public void First_WithErrorMessage_ThrowsExceptionWithMessage()
        {
            m_DataList = new List<int>();
            string message = "user error message";
            Action act = () => m_DataList.First(message);

            act.ShouldThrow<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void First_WithFilter_ThrowsExceptionWithMessage()
        {
            string message = "user filter 47 error message";
            Action act = () => m_DataList.First(x => x == 47, message);

            act.ShouldThrow<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void First_Get_ReturnElement()
        {
            string message = "user error message";

            var returnValue = m_DataList.First(message);
            returnValue.Should().Be(0);
        }

        [Test]
        public void First_WithFilter_ReturnElement()
        {
            string message = "user error message";
            var returnValue = m_DataList.First(x => x == 3, message);

            returnValue.Should().Be(3);
        }
    }
}