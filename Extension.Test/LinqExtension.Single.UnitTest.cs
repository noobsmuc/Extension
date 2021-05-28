using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class SingleUnitTest
    {
        private List<int> m_DataList;

        [SetUp]
        public void Setup()
        {
            m_DataList = Enumerable.Range(0, 10).ToList();           
        }

        [Test]
        public void Single_WithErrorMessage_ThrowsExceptionWithMessage()
        {
            string message = "user error message";
            Action act = () => m_DataList.Single(message);

            act.Should().Throw<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void Single_WithFilter_ThrowsExceptionWithMessage()
        {
            string message = "user filter 42 error message";
            Action act = () => m_DataList.Single(x => x == 42, message);

            act.Should().Throw<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void Single_Get_ReturnElement()
        {
            m_DataList = new List<int>{17};
            string message = "user error message";

            var returnValue = m_DataList.Single(message);
            returnValue.Should().Be(17);
        }

        [Test]
        public void Single_WithFilter_ReturnElement()
        {
            string message = "user error message";
            var returnValue = m_DataList.Single(x => x == 5, message);

            returnValue.Should().Be(5);
        }

        [Test]
        public void SingleOrDefault_Get_ReturnElement()
        {
            m_DataList = new List<int> { 22 };
            string message = "user error message";
            var returnValue = m_DataList.SingleOrDefault(message);

            returnValue.Should().Be(22);
        }

        [Test]
        public void SingleOrDefault_WithFilter_ReturnElement()
        {
            string message = "user error message";
            var returnValue = m_DataList.SingleOrDefault(x => x == 4, message);

            returnValue.Should().Be(4);
        }

        [Test]
        public void SingleOrDefault_WithFilter_ThrowsException()
        {
            string message = "user SingleOrDefaulterror message";
            Action act = () => m_DataList.SingleOrDefault(x => x == 4 || x == 5, message);

            act.Should().Throw<InvalidOperationException>().WithMessage(message);
        }

        [Test]
        public void SingleOrDefault_Get_ThrowsException()
        {          
            string message = "user SingleOrDefaulterror message";
            Action act = () => m_DataList.SingleOrDefault(message);

            act.Should().Throw<InvalidOperationException>().WithMessage(message);
        }
    }
}