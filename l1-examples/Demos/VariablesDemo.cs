namespace L1Examples.Demos;

// Variables, types, and type inference with var.
public static class VariablesDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Variables and types ---");

        // Value types: fixed-size, copied by value.
        int age = 21;
        double price = 4.95;
        bool isReady = true;
        char letter = 'A';

        // Reference type: lives on the heap, variable holds a reference.
        string name = "Alice";

        Console.WriteLine($"int age       = {age}");
        Console.WriteLine($"double price  = {price}");
        Console.WriteLine($"bool isReady  = {isReady}");
        Console.WriteLine($"char letter   = {letter}");
        Console.WriteLine($"string name   = {name}");

        // 'var' is not "dynamic" — the compiler picks the type
        // from the right-hand side, and it is fixed after that.
        var count = 10;         // int
        var greeting = "Hi";    // string

        Console.WriteLine($"\nvar count is a {count.GetType().Name}");
        Console.WriteLine($"var greeting is a {greeting.GetType().Name}");

        // A common trap: integer division discards the remainder.
        int a = 7, b = 2;
        Console.WriteLine($"\nint 7 / 2   = {a / b}       // integer division");
        Console.WriteLine($"double 7 / 2 = {(double)a / b}   // cast one operand");
    }
}
