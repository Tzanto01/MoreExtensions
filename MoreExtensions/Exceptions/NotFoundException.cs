namespace MoreExtensions.Extensions.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message = "")
    {
        throw new Exception(message);
    }
}