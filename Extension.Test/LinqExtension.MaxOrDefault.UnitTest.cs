using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
	[TestFixture]
	public class MaxOrDefaultUnitTest
	{
        [Test]
        public void MaxOrDefault_StringDataExisting_ReturnsMinValue()
        {
            var dataList = new List<string>() { "noobs", "muc" };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be("noobs");
        }

        [Test]
        public void MaxOrDefault_NullableIntDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<int?>() { 15, 18, null, 55 };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55);
        }

        [Test]
		public void MaxOrDefault_IntDataExisting_ReturnsMaxValue()
		{
            var dataList = Enumerable.Range(101, 2055).ToList();
            var result = dataList.Select(x => x).MaxOrDefault();
			result.Should().Be(2155);
		}

		[Test]
		public void MaxOrDefault_IntEmpytList_ReturnsDefault()
		{
			var result = new List<int>().Select(x => x).MaxOrDefault();
			result.Should().Be(0);
		}


        [Test]
        public void MaxOrDefault_NullableLongDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<long?>() { 15, 18, null, 55 };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55);
        }

        [Test]
        public void MaxOrDefault_LongDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<long>() { 15, 18, 55 };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55);
        }

        [Test]
        public void MaxOrDefault_LongEmpytList_ReturnsDefault()
        {
            var result = new List<long>().Select(x => x).MaxOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void MaxOrDefault_NullableFloatDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<float?>() { 15.2F, 18.6F, null, 55.23F };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23F);
        }

        [Test]
        public void MaxOrDefault_FloatDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<float>() { 15.2F, 18.6F, 55.23F };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23F);
        }

        [Test]
        public void MaxOrDefault_FloatEmpytList_ReturnsDefault()
        {
            var result = new List<float>().Select(x => x).MaxOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void MaxOrDefault_NullableDoubleDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<double?>() { 15.2, null, 18.6, 55.23 };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23);
        }
        
        [Test]
        public void MaxOrDefault_DoubleDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<double>() { 15.2, 18.6, 55.23 };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23);
        }

        [Test]
        public void MaxOrDefault_DoubleEmpytList_ReturnsDefault()
        {
            var result = new List<double>().Select(x => x).MaxOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void MaxOrDefault_NullableDecimalDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<decimal?>() { 15.2M, null, 18.6M, 55.23M };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23M);
        }
        
        [Test]
        public void MaxOrDefault_DecimalDataExisting_ReturnsMaxValue()
        {
            var dataList = new List<decimal>() { 15.2M, 18.6M, 55.23M };
            var result = dataList.Select(x => x).MaxOrDefault();
            result.Should().Be(55.23M);
        }

        [Test]
        public void MaxOrDefault_DecimalEmpytList_ReturnsDefault()
        {
            var result = new List<decimal>().Select(x => x).MaxOrDefault();
            result.Should().Be(0);
        }
    }
}
