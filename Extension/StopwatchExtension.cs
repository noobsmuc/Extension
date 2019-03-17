using System;
using System.Diagnostics;

namespace NoobsMuc.Extension
{
    public static class StopwatchExtension
    {
        public static string ToFormatedString(this Stopwatch input, string format)
        {
            if (string.IsNullOrEmpty(format))
                throw new ArgumentException("format is undefined");

            return TimeSpan.FromMilliseconds(input.ElapsedMilliseconds).ToString(format);
        }
    }
}
