namespace L1Examples.Demos;

// Strings: interpolation, formatting, common methods, nullability.
public static class StringsDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Strings and interpolation ---");

        string first = "Alice";
        string last = "Andersson";

        // Concatenation with + works, but interpolation reads better.
        string full1 = first + " " + last;
        string full2 = $"{first} {last}";
        Console.WriteLine($"Concatenation : {full1}");
        Console.WriteLine($"Interpolation : {full2}");

        // Number formatting inside interpolation.
        double price = 4.5;
        Console.WriteLine($"Total: {price:F2} EUR    // two decimals");
        Console.WriteLine($"Pi   : {Math.PI:F4}       // four decimals");

        // Useful string methods.
        string s = "  Hello, World!  ";
        Console.WriteLine($"\nOriginal      : \"{s}\"");
        Console.WriteLine($"Trim()        : \"{s.Trim()}\"");
        Console.WriteLine($"ToUpper()     : \"{s.ToUpper()}\"");
        Console.WriteLine($"Replace()     : \"{s.Replace("Hello", "Hi")}\"");
        Console.WriteLine($"Contains(\"World\") : {s.Contains("World")}");

        // Nullable strings.
        string? maybeName = null;
        int length = maybeName?.Length ?? 0;   // null-conditional + null-coalescing
        Console.WriteLine($"\nlength of null string, safely: {length}");
    }
}
