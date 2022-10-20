namespace MoreExtensions.Extensions;

public static class IntExtensions
{
    public static void Times(this int i, Action a)
    {
        foreach (var _ in ..i) 
            a();
    }

    public static IEnumerable<int> To(this int fromNumber, int toNumber)
    {
        while (fromNumber <= toNumber)
        {
            yield return fromNumber;
            fromNumber++;
        }
    }
}