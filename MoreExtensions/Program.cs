namespace MoreExtensions.Extensions;

public class Program
{
    public static void Main()
    {
        // Used to test the possible Extensions
        PrintLn(new[] { "Nico", "Lucas", "Carina", "Volker" }.Where(x => x == "Nico"));

    }
}