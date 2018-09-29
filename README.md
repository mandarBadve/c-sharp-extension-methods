# c-sharp-extension-methods
Useful C# Extension Methods

This is collection of C# extension methods.

## Collection
### NotNullOrEmpty<T>(this IList<T> list)
Checks List is null and have at least one item

### NotNullOrEmpty<T>(this IEnumerable<T> list)
Checks IEnumerable is null and have at least one item

### AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
Add or Update dictionary
     - Adds new key value pair if key is not exist
     - Update value if provided key exist


