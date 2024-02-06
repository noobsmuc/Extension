using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class AverageOrDefaultUnitTest
    {
        [Test]
        public void AverageOrDefault_NullableIntDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<int?>() { 15, 18, null, 55 };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.333333333333332);
        }

        [Test]
        public void AverageOrDefault_IntDataExisting_ReturnsAverageValue()
        {
            var dataList = Enumerable.Range(101, 2055).ToList();
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(1128.0);
        }

        [Test]
        public void AverageOrDefault_IntEmpytList_ReturnsDefault()
        {
            var result = new List<int>().Select(x => x).AverageOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void AverageOrDefault_NullableLongDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<long?>() { 15, 18, null, 55 };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.333333333333332);
        }

        [Test]
        public void AverageOrDefault_LongDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<long>() { 15, 18, 55 };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.333333333333332);
        }

        [Test]
        public void AverageOrDefault_LongEmpytList_ReturnsDefault()
        {
            var result = new List<long>().Select(x => x).AverageOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void AverageOrDefault_NullableFloatDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<float?>() { 15.2F, 18.6F, null, 55.23F };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.6766663F);
        }

        [Test]
        public void AverageOrDefault_FloatDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<float>() { 15.2F, 18.6F, 55.23F };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.6766663F);
        }

        [Test]
        public void AverageOrDefault_FloatEmpytList_ReturnsDefault()
        {
            var result = new List<float>().Select(x => x).AverageOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void AverageOrDefault_NullableDoubleDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<double?>() { 15.2, null, 18.6, 55.23 };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.676666666666666);
        }

        [Test]
        public void AverageOrDefault_DoubleDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<double>() { 15.2, 18.6, 55.23 };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.676666666666666);
        }

        [Test]
        public void AverageOrDefault_DoubleEmpytList_ReturnsDefault()
        {
            var result = new List<double>().Select(x => x).AverageOrDefault();
            result.Should().Be(0);
        }


        [Test]
        public void AverageOrDefault_NullableDecimalDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<decimal?>() { 15.2M, null, 18.6M, 55.23M };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.676666666666666666666666667M);
        }

        [Test]
        public void AverageOrDefault_DecimalDataExisting_ReturnsAverageValue()
        {
            var dataList = new List<decimal>() { 15.2M, 18.6M, 55.23M };
            var result = dataList.Select(x => x).AverageOrDefault();
            result.Should().Be(29.676666666666666666666666667M);
        }

        [Test]
        public void AverageOrDefault_DecimalEmpytList_ReturnsDefault()
        {
            var result = new List<decimal>().Select(x => x).AverageOrDefault();
            result.Should().Be(0);
        }
    }
}
