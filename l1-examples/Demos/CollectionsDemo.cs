namespace L1Examples.Demos;

// Arrays and List<T>: creation, iteration, common operations.
public static class CollectionsDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Arrays and List<T> ---");

        // Array — fixed size, known at creation.
        int[] numbers = { 1, 2, 3, 4 };
        Console.WriteLine($"array length: {numbers.Length}");
        Console.WriteLine($"numbers[2]  : {numbers[2]}");

        Console.Write("array items : ");
        foreach (int n in numbers) Console.Write($"{n} ");
        Console.WriteLine();

        // List<T> — grows and shrinks.
        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Cara");
        names.Remove("Alice");

        Console.WriteLine($"\nList count  : {names.Count}");
        Console.WriteLine($"names[0]    : {names[0]}");

        // Collection expression (C# 12).
        List<int> primes = [2, 3, 5, 7, 11];
        Console.Write("primes list : ");
        foreach (int p in primes) Console.Write($"{p} ");
        Console.WriteLine();

        // Handy LINQ methods on any collection.
        Console.WriteLine($"\nprimes.Sum()     = {primes.Sum()}");
        Console.WriteLine($"primes.Max()     = {primes.Max()}");
        Console.WriteLine($"primes.Count(p => p > 4) = {primes.Count(p => p > 4)}");
    }
}
