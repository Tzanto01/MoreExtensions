namespace MoreExtensions.SupportingClasses;

public ref struct CustomIntEnumerator
{
    private readonly int _end;
    public CustomIntEnumerator(Range range)
    {
        if (range.End.IsFromEnd)
            throw new NotSupportedException();
        
        Current = range.Start.Value - 1;
        _end = range.End.Value;
    }

    public int Current { get; private set; }

    public bool MoveNext()
    {
        Current++;
        return Current <= _end;
    }
}