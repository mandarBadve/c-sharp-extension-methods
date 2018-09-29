using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExtensions
{
    public static class Collection
    {
        /// <summary>
        /// Checks List is null and have at least one item
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="list">List</param>
        /// <returns>Return true if list is null and don't have any items.</returns>
        public static bool NotNullOrEmpty<T>(this IList<T> list)
        {
            return list != null && list.Any();
        }

        /// <summary>
        /// Checks IEnumerable is null and have at least one item
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="list">IEnumerable</param>
        /// <returns>Return true if IEnumerable is null and don't have any items.</returns>
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return list != null && list.Any();
        }

        /// <summary>
        /// Add or Update dictionary
        ///     - Adds new key value pair if key is not exist
        ///     - Update value if provided key exist
        /// </summary>
        /// <typeparam name="TKey">Key</typeparam>
        /// <typeparam name="TValue">Value</typeparam>
        /// <param name="dictionary">Dictionary</param>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }
    }
}
