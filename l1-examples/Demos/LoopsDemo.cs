namespace L1Examples.Demos;

// Loops: for, while, do/while, foreach.
public static class LoopsDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Loops ---");

        // for — use it when you need an index or a known count.
        Console.WriteLine("for:");
        for (int i = 0; i < 5; i++)
            Console.WriteLine($"  i = {i}");

        // while — the condition is checked BEFORE each iteration.
        Console.WriteLine("\nwhile (countdown):");
        int n = 3;
        while (n > 0)
        {
            Console.WriteLine($"  n = {n}");
            n--;
        }

        // do / while — the body runs at least once.
        Console.WriteLine("\ndo/while (runs at least once):");
        int m = 0;
        do
        {
            Console.WriteLine($"  m = {m}");
            m++;
        } while (m < 2);

        // foreach — prefer this over for when the index does not matter.
        Console.WriteLine("\nforeach:");
        string[] names = { "Alice", "Bob", "Cara" };
        foreach (string name in names)
            Console.WriteLine($"  hi, {name}!");

        // break and continue — escape hatches for a loop.
        Console.WriteLine("\nfor with break and continue:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 3) continue;   // skip 3
            if (i == 7) break;      // stop at 7
            Console.WriteLine($"  i = {i}");
        }
    }
}
