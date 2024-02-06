using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class MinOrDefaultUnitTest
    {
        [Test]
        public void MinOrDefault_StringDataExisting_ReturnsMinValue()
        {
            var dataList = new List<string>() { "noobs", "muc" };
            var result = dataList.Select(x => x).MinOrDefault();
            result.Should().Be("muc");
        }

        [Test]
        public void MinOrDefault_NullableIntDataExisting_ReturnsMinValue()
        {
            var dataList = new List<int?>() { 15, 18, null, 55 };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15);
        }

        [Test]
        public void MinOrDefault_IntDataExisting_ReturnsMinValue()
        {
            var dataList = Enumerable.Range(101, 2055).ToList();
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(101);
        }

        [Test]
        public void MinOrDefault_IntEmpytList_ReturnsDefault()
        {
            var min = new List<int>().Select(x => x).MinOrDefault();
            min.Should().Be(0);
        }


        [Test]
        public void MinOrDefault_NullableLongDataExisting_ReturnsMinValue()
        {
            var dataList = new List<long?>() { 15, 18, null, 55 };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15);
        }

        [Test]
        public void MinOrDefault_LongDataExisting_ReturnsMinValue()
        {
            var dataList = new List<long>() { 15, 18, 55 };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15);
        }

        [Test]
        public void MinOrDefault_LongEmpytList_ReturnsDefault()
        {
            var min = new List<long>().Select(x => x).MinOrDefault();
            min.Should().Be(0);
        }


        [Test]
        public void MinOrDefault_NullableFloatDataExisting_ReturnsMinValue()
        {
            var dataList = new List<float?>() { 15.2F, 18.6F, null, 55.23F };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2F);
        }

        [Test]
        public void MinOrDefault_FloatDataExisting_ReturnsMinValue()
        {
            var dataList = new List<float>() { 15.2F, 18.6F, 55.23F };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2F);
        }

        [Test]
        public void MinOrDefault_FloatEmpytList_ReturnsDefault()
        {
            var min = new List<float>().Select(x => x).MinOrDefault();
            min.Should().Be(0);
        }


        [Test]
        public void MinOrDefault_NullableDoubleDataExisting_ReturnsMinValue()
        {
            var dataList = new List<double?>() { 15.2, null, 18.6, 55.23 };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2);
        }

        [Test]
        public void MinOrDefault_DoubleDataExisting_ReturnsMinValue()
        {
            var dataList = new List<double>() { 15.2, 18.6, 55.23 };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2);
        }

        [Test]
        public void MinOrDefault_DoubleEmpytList_ReturnsDefault()
        {
            var min = new List<double>().Select(x => x).MinOrDefault();
            min.Should().Be(0);
        }


        [Test]
        public void MinOrDefault_NullableDecimalDataExisting_ReturnsMinValue()
        {
            var dataList = new List<decimal?>() { 15.2M, null, 18.6M, 55.23M };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2M);
        }

        [Test]
        public void MinOrDefault_DecimalDataExisting_ReturnsMinValue()
        {
            var dataList = new List<decimal>() { 15.2M, 18.6M, 55.23M };
            var min = dataList.Select(x => x).MinOrDefault();
            min.Should().Be(15.2M);
        }

        [Test]
        public void MinOrDefault_DecimalEmpytList_ReturnsDefault()
        {
            var min = new List<decimal>().Select(x => x).MinOrDefault();
            min.Should().Be(0);
        }
    }
}
