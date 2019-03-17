using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace NoobsMuc.Extension
{
    public static class StringExtension
    {
        public static string Left(this string input, int length)
        {
            if (length < 0)
                return string.Empty;

            return input.Substring(0, Math.Min(length,input.Length));
        }

        public static string Right(this string input, int length)
        {
            if (length < 0)
                return string.Empty;
            
            return input.Substring(input.Length - Math.Min(length, input.Length));
        }

        public static string ReplaceExactWord(this string input, string oldValue, string newValue)
        {
            //https://stackoverflow.com/questions/13870725/how-to-search-and-replace-exact-matching-strings-only
            return Regex.Replace(input, $@"\b{oldValue}\b", newValue);
        }
    }
}