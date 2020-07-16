using System;
using System.Collections.Generic;
using System.Linq;

namespace Squelch.Library.Extensions
{
    internal static class ListEx
    {
        /// <summary>
        /// Copies the list to a new list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> Copy<T>(this List<T> list)
        {
            T[] newList = new T[list.Count];
            list.CopyTo(newList);

            return newList.ToList();
        }

        /// <summary>
        /// Returns a random element from the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T Random<T>(this List<T> list)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            return list[random.Next(0, list.Count() - 1)];
        }
    }
}