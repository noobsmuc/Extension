using System;
using System.Collections;
using NUnit.Framework;

namespace NoobsMuc.Extension
{
    [TestFixture]
    public class DateTimeExtension
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test, TestCaseSource(typeof(TestData), "StartOfWeek")]
        public DateTime StartOfWeek(DateTime date)
        {
            return date.StartOfWeek();
        }

        [Test, TestCaseSource(typeof(TestData), "EndOfWeek")]
        public DateTime EndOfWeek(DateTime date)
        {
            return date.EndOfWeek();
        }

        [Test, TestCaseSource(typeof(TestData), "StartOfMonth")]
        public DateTime StartOfMonth(DateTime date)
        {
            return date.StartOfMonth();
        }

        [Test, TestCaseSource(typeof(TestData), "EndOfMonth")]
        public DateTime EndOfMonth(DateTime date)
        {
            return date.EndOfMonth();
        }

        [Test, TestCaseSource(typeof(TestData), "StartOfPreviousMonth")]
        public DateTime StartOfPreviousMonth(DateTime date)
        {
            return date.StartOfPreviousMonth();
        }

        [Test, TestCaseSource(typeof(TestData), "EndOfPreviousMonth")]
        public DateTime EndOfPreviousMonth(DateTime date)
        {
            return date.EndOfPreviousMonth();
        }

        [Test, TestCaseSource(typeof(TestData), "StartOfYear")]
        public DateTime StartOfYear(DateTime date)
        {
            return date.StartOfYear();
        }

        [Test, TestCaseSource(typeof(TestData), "EndOfYear")]
        public DateTime EndOfYear(DateTime date)
        {
            return date.EndOfYear();
        }

        [Test, TestCaseSource(typeof(TestData), "DaysInMonth")]
        public int DaysInMonth(DateTime date)
        {
            return date.DaysInMonth();
        }

        [Test, TestCaseSource(typeof(TestData), "DaysInYear")]
        public int DaysInYear(DateTime date)
        {
            return date.DaysInYear();
        }

        public class TestData
        {
            public static IEnumerable StartOfWeek
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 29)).Returns(new DateTime(2016, 2, 29));
                    yield return new TestCaseData(new DateTime(2016, 3, 3)).Returns(new DateTime(2016, 2, 29));
                    yield return new TestCaseData(new DateTime(2017, 12, 28)).Returns(new DateTime(2017, 12, 25));
                    yield return new TestCaseData(new DateTime(2018, 1, 4)).Returns(new DateTime(2018, 1, 1));
                    yield return new TestCaseData(new DateTime(2019, 1, 2)).Returns(new DateTime(2018, 12, 31));
                }
            }

            public static IEnumerable EndOfWeek
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 25)).Returns(new DateTime(2016, 2, 28));
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(new DateTime(2016, 2, 28));
                    yield return new TestCaseData(new DateTime(2018, 1, 2)).Returns(new DateTime(2018, 1, 7));
                }
            }

            public static IEnumerable StartOfMonth
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(new DateTime(2016, 2, 1));
                    yield return new TestCaseData(new DateTime(2017, 8, 31)).Returns(new DateTime(2017, 8, 1));
                    yield return new TestCaseData(new DateTime(2018, 4, 15)).Returns(new DateTime(2018, 4, 1));
                }
            }

            public static IEnumerable EndOfMonth
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2000, 2, 22)).Returns(new DateTime(2000, 2, 29));
                    yield return new TestCaseData(new DateTime(2016,2,22)).Returns(new DateTime(2016,2,29));
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(new DateTime(2017, 8, 31));
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(new DateTime(2018, 9, 30));
                    yield return new TestCaseData(new DateTime(2018, 12, 5)).Returns(new DateTime(2018, 12, 31));
                    yield return new TestCaseData(new DateTime(2100, 2, 22)).Returns(new DateTime(2100, 2, 28));
                }
            }

            public static IEnumerable StartOfPreviousMonth
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(new DateTime(2016, 1, 1));
                    yield return new TestCaseData(new DateTime(2017, 1, 12)).Returns(new DateTime(2016, 12, 1));
                    yield return new TestCaseData(new DateTime(2018, 4, 15)).Returns(new DateTime(2018, 3, 1));
                }
            }

            public static IEnumerable EndOfPreviousMonth
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2000, 3, 22)).Returns(new DateTime(2000, 2, 29));
                    yield return new TestCaseData(new DateTime(2016, 3, 22)).Returns(new DateTime(2016, 2, 29));
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(new DateTime(2017, 7, 31));
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(new DateTime(2018, 8, 31));
                    yield return new TestCaseData(new DateTime(2018, 1, 5)).Returns(new DateTime(2017, 12, 31));
                    yield return new TestCaseData(new DateTime(2100, 3, 22)).Returns(new DateTime(2100, 2, 28));
                }
            }

            public static IEnumerable StartOfYear
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 29)).Returns(new DateTime(2016, 1, 1));
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(new DateTime(2017, 1, 1));
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(new DateTime(2018, 1, 1));
                    yield return new TestCaseData(new DateTime(2018, 12, 5)).Returns(new DateTime(2018, 1, 1));
                }
            }

            public static IEnumerable EndOfYear
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(new DateTime(2016, 12, 31));
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(new DateTime(2017, 12, 31));
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(new DateTime(2018, 12, 31));
                    yield return new TestCaseData(new DateTime(2018, 12, 5)).Returns(new DateTime(2018, 12, 31));
                }
            }

            public static IEnumerable DaysInMonth
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(29);
                    yield return new TestCaseData(new DateTime(2017, 2, 22)).Returns(28);
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(31);
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(30);
                }
            }

            public static IEnumerable DaysInYear
            {
                get
                {
                    yield return new TestCaseData(new DateTime(2016, 2, 22)).Returns(366);
                    yield return new TestCaseData(new DateTime(2017, 8, 18)).Returns(365);
                    yield return new TestCaseData(new DateTime(2018, 9, 11)).Returns(365);
                    yield return new TestCaseData(new DateTime(2020, 5, 15)).Returns(366);
                    yield return new TestCaseData(new DateTime(2100, 5, 15)).Returns(365);
                }
            }
        }
    }
}