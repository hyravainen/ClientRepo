namespace L1Examples.Demos;

// Methods: parameters, return values, optional / named args, expression-bodied form.
public static class MethodsDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Methods ---");

        // Basic call with return value.
        int s = Square(4);
        Console.WriteLine($"Square(4)          = {s}");

        // Expression-bodied method.
        int c = Cube(3);
        Console.WriteLine($"Cube(3)            = {c}");

        // Default argument value.
        Console.WriteLine($"Greet(\"Alice\")     = {Greet("Alice")}");

        // Named argument, overriding the default.
        Console.WriteLine($"Greet(\"Bob\", ...)  = {Greet("Bob", prefix: "Hi")}");

        // Method that has no return value.
        PrintBanner("Course started");

        // Multiple return values via tuple.
        (int min, int max) = MinMax(new[] { 4, 1, 9, 3, 7 });
        Console.WriteLine($"MinMax result      = min {min}, max {max}");
    }

    private static int Square(int x)
    {
        return x * x;
    }

    // Expression-bodied member: same as { return x * x * x; }
    private static int Cube(int x) => x * x * x;

    // 'prefix' is optional — defaults to "Hello".
    private static string Greet(string name, string prefix = "Hello")
        => $"{prefix}, {name}!";

    private static void PrintBanner(string text)
    {
        string bar = new string('=', text.Length + 4);
        Console.WriteLine(bar);
        Console.WriteLine($"= {text} =");
        Console.WriteLine(bar);
    }

    private static (int Min, int Max) MinMax(int[] xs)
        => (xs.Min(), xs.Max());
}
