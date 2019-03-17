using System;

namespace NoobsMuc.Extension
{
    public static class DateTimeExtension
    {
        public static DateTime StartOfWeek(this DateTime input)
        {
            var dateTimeNow = input;
            if (dateTimeNow.DayOfWeek == DayOfWeek.Sunday)
                dateTimeNow = dateTimeNow.AddDays(-1);

            int delta = DayOfWeek.Monday - dateTimeNow.DayOfWeek;
            return dateTimeNow.AddDays(delta).Date;
        }

        public static DateTime EndOfWeek(this DateTime input)
        {
            return StartOfWeek(input).AddDays(6).Date;
        }

        public static DateTime StartOfMonth(this DateTime input)
        {
            return new DateTime(input.Year, input.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime input)
        {
            return StartOfMonth(input).AddMonths(1).AddDays(-1);
        }

        public static DateTime StartOfPreviousMonth(this DateTime input)
        {
            input = input.AddMonths(-1);
            return new DateTime(input.Year, input.Month, 1);
        }

        public static DateTime EndOfPreviousMonth(this DateTime input)
        {
            input = input.AddMonths(-1);
            return StartOfMonth(input).AddMonths(1).AddDays(-1);
        }

        public static DateTime StartOfYear(this DateTime input)
        {
            return new DateTime(input.Year, 1, 1);
        }

        public static DateTime EndOfYear(this DateTime input)
        {
            return new DateTime(input.Year, 12, 31);
        }

        public static int DaysInMonth(this DateTime input)
        {
            return (int)(EndOfMonth(input) - StartOfMonth(input).AddDays(-1)).TotalDays;
        }

        public static int DaysInYear(this DateTime input)
        {
            return  EndOfYear(input).DayOfYear;
        }
    }
}