using MoreExtensions.SupportingClasses;

namespace MoreExtensions;

public static class RangeExtensions
{
    public static CustomIntEnumerator GetEnumerator(this Range range)
        => new (range);
}

