using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
	[TestFixture]
	public class MinOrDefaultUnitTest
	{
		private List<int> m_DataList;

		[SetUp]
		public void Setup()
		{
			m_DataList = Enumerable.Range(101, 2055).ToList();
		}

		[Test]
		public void MinOrDefaultUnitTest_DataExisting_ReturnsMinValue()
		{
			var min = m_DataList.Select(x => x).MinOrDefault();
			min.Should().Be(101);
		}


		[Test]
		public void MinOrDefaultUnitTest_EmpytList_ReturnsDefault()
		{
			var min = new List<int>().Select(x => x).MinOrDefault();
			min.Should().Be(0);
		}
	}
}
