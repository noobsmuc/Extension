using System;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
    public static class Linq
    {
        #region MinOrDefault

        public static T MinOrDefault<T>(this IEnumerable<T> source)
        {
            return source.Any() ? source.Min() : default(T);
        }

        public static int MinOrDefault(this IEnumerable<int> source)
        {
            return source.Any() ? source.Min() : default(int);
        }

        public static int? MinOrDefault(this IEnumerable<int?> source)
        {
            return source.Any() ? source.Min() : default(int?);
        }

        public static long MinOrDefault(this IEnumerable<long> source)
        {
            return source.Any() ? source.Min() : default(long);
        }

        public static long? MinOrDefault(this IEnumerable<long?> source)
        {
            return source.Any() ? source.Min() : default(long?);
        }

        public static float MinOrDefault(this IEnumerable<float> source)
        {
            return source.Any() ? source.Min() : default(float);
        }

        public static float? MinOrDefault(this IEnumerable<float?> source)
        {
            return source.Any() ? source.Min() : default(float?);
        }

        public static double MinOrDefault(this IEnumerable<double> source)
        {
            return source.Any() ? source.Min() : default(double);
        }

        public static double? MinOrDefault(this IEnumerable<double?> source)
        {
            return source.Any() ? source.Min() : default(double?);
        }

        public static decimal MinOrDefault(this IEnumerable<decimal> source)
        {
            return source.Any() ? source.Min() : default(decimal);
        }

        public static decimal? MinOrDefault(this IEnumerable<decimal?> source)
        {
            return source.Any() ? source.Min() : default(decimal?);
        }

        #endregion  MinOrDefault

        #region MaxOrDefault

        public static T MaxOrDefault<T>(this IEnumerable<T> source)
        {
            return source.Any() ? source.Max() : default(T);
        }

        public static int MaxOrDefault(this IEnumerable<int> source)
        {
            return source.Any() ? source.Max() : default(int);
        }

        public static int? MaxOrDefault(this IEnumerable<int?> source)
        {
            return source.Any() ? source.Max() : default(int?);
        }

        public static long MaxOrDefault(this IEnumerable<long> source)
        {
            return source.Any() ? source.Max() : default(long);
        }

        public static long? MaxOrDefault(this IEnumerable<long?> source)
        {
            return source.Any() ? source.Max() : default(long?);
        }

        public static float MaxOrDefault(this IEnumerable<float> source)
        {
            return source.Any() ? source.Max() : default(float);
        }

        public static float? MaxOrDefault(this IEnumerable<float?> source)
        {
            return source.Any() ? source.Max() : default(float?);
        }

        public static double MaxOrDefault(this IEnumerable<double> source)
        {
            return source.Any() ? source.Max() : default(double);
        }

        public static double? MaxOrDefault(this IEnumerable<double?> source)
        {
            return source.Any() ? source.Max() : default(double?);
        }

        public static decimal MaxOrDefault(this IEnumerable<decimal> source)
        {
            return source.Any() ? source.Max() : default(decimal);
        }

        public static decimal? MaxOrDefault(this IEnumerable<decimal?> source)
        {
            return source.Any() ? source.Max () : default(decimal?);
        }

        #endregion MaxOrDefault

        #region AverageOrDefault
        public static double AverageOrDefault(this IEnumerable<int> source)
        {
            return source.Any() ? source.Average() : default(int);
        }

        public static double? AverageOrDefault(this IEnumerable<int?> source)
        {
            return source.Any() ? source.Average() : default(int?);
        }

        public static double AverageOrDefault(this IEnumerable<long> source)
        {
            return source.Any() ? source.Average() : default(long);
        }

        public static double? AverageOrDefault(this IEnumerable<long?> source)
        {
            return source.Any() ? source.Average() : default(long?);
        }

        public static float AverageOrDefault(this IEnumerable<float> source)
        {
            return source.Any() ? source.Average() : default(float);
        }

        public static float? AverageOrDefault(this IEnumerable<float?> source)
        {
            return source.Any() ? source.Average() : default(float?);
        }

        public static double AverageOrDefault(this IEnumerable<double> source)
        {
            return source.Any() ? source.Average() : default(double);
        }

        public static double? AverageOrDefault(this IEnumerable<double?> source)
        {
            return source.Any() ? source.Average() : default(double?);
        }

        public static decimal AverageOrDefault(this IEnumerable<decimal> source)
        {
            return source.Any() ? source.Average() : default(decimal);
        }

        public static decimal? AverageOrDefault(this IEnumerable<decimal?> source)
        {
            return source.Any() ? source.Average() : default(decimal?);
        }

        #endregion AverageOrDefault

        public static T Single<T>(this IEnumerable<T> source, string errorMessage)
        {
            return Execute(source.Single, errorMessage);
        }

        public static T Single<T>(this IEnumerable<T> source, Func<T, bool> predicate, string errorMessage)
        {
            return Execute(() => source.Single(predicate), errorMessage);
        }

        public static T SingleOrDefault<T>(this IEnumerable<T> source, string errorMessage)
        {
            return Execute(source.SingleOrDefault, errorMessage);
        }

        public static T SingleOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, string errorMessage)
        {
            return Execute(() => source.SingleOrDefault(predicate), errorMessage);
        }

        public static T First<T>(this IEnumerable<T> source, string errorMessage)
        {
            return Execute(source.First, errorMessage);
        }

        public static T First<T>(this IEnumerable<T> source, Func<T, bool> predicate, string errorMessage)
        {
            return Execute(() => source.First(predicate), errorMessage);
        }

        public static T Last<T>(this IEnumerable<T> source, string errorMessage)
        {
            return Execute(source.Last, errorMessage);
        }
        public static T Last<T>(this IEnumerable<T> source, Func<T, bool> predicate, string errorMessage)
        {
            return Execute(() => source.Last(predicate), errorMessage);
        }
        
        private static T Execute<T>(Func<T> execute, string errorMessage)
        {
            try
            {
                return execute.Invoke();
            }
            catch (ArgumentNullException exception)
            {
                throw new ArgumentNullException(errorMessage, exception);
            }
            catch (InvalidOperationException exception)
            {
                throw new InvalidOperationException(errorMessage, exception);
            }
        }
    }
}