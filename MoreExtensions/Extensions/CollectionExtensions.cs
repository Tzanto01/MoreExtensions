using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MoreExtensions;

public static class CollectionExtensions
{
    public static void ForEach<T>(this IEnumerable<T> collection, Action a)
    {
        foreach (var _ in collection)
        {
            a();
        }
    }
    
    public static void ForEach<T>(this IEnumerable<T> collection, Action<T> a)
    {
        foreach (var it in collection)
        {
            a(it);
        }
    }
}