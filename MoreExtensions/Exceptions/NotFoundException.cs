namespace MoreExtensions.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message = "")
    {
        throw new Exception(message);
    }
}