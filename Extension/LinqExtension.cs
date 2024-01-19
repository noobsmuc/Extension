using System;
using System.Collections.Generic;
using System.Linq;

namespace NoobsMuc.Extension
{
    public static class Linq
    {
        public static T MinOrDefault<T>(this IEnumerable<T> source)
        {
            if (source.Any())
            {
                return source.Min<T>();
            }
            else
            {
                return default(T);
            }
        }

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