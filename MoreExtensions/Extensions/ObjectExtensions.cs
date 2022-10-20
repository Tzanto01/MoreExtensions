namespace MoreExtensions.Extensions;

public static class ObjectExtensions
{
    public static object? ToNull(this object o) => null;
    public static void TryDispose(this object target, bool throwException = false)
    {
        if (target is not IDisposable disposable)
            return;

        try
        {
            disposable.Dispose();
        }
        catch (Exception)
        {
            if (throwException)
                throw;
        }
    }
}