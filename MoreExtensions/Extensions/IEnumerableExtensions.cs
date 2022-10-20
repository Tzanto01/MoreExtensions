using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MoreExtensions.Extensions;

public static class IEnumerableExtensions
{
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action a)
    {
        var col = collection as T[] ?? collection.ToArray();
        foreach (var _ in col)
            a();
        return col;
    }
    
    public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> a)
    {
        var col = collection as T[] ?? collection.ToArray();
        foreach (var it in col)
            a(it);
        return col;
    }
    
    public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
    {
        return condition ? source.Where(predicate) : source;
    }

    public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, int, bool> predicate)
    {
        return condition ? source.Where(predicate) : source;
    }
}