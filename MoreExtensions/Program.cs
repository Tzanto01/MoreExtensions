namespace MoreExtensions;

public class Program
{
    public static void Main()
    {
        // Used to test the possible Extensions
        Console.WriteLine("test", "test1", "test2");
        new[]{'H', 'A', 'L', 'L', 'O'}.ForEach(PrintLn);

    }
}