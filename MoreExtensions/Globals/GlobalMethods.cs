using System.Runtime.InteropServices;

namespace MoreExtensions.Globals;

public static class GlobalMethods
{
    public static void PrintLn<T>(T? arg) => Console.WriteLine(arg);
    public static void Print<T>(T arg) => Console.Write(arg);
}