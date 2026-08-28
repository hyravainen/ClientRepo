using L1Examples.Demos;

// Lecture 1 examples — pick a demo by number.
// You can also comment out the menu and call any demo directly.

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Lecture 1 — C# refresher demos ===");
    Console.WriteLine("  1) Variables and types");
    Console.WriteLine("  2) Strings and interpolation");
    Console.WriteLine("  3) Control flow (if / switch)");
    Console.WriteLine("  4) Loops (for / while / foreach)");
    Console.WriteLine("  5) Methods");
    Console.WriteLine("  6) Arrays and List<T>");
    Console.WriteLine("  7) Person class + ToString()");
    Console.WriteLine("  0) Quit");
    Console.Write("\nChoice: ");

    string? input = Console.ReadLine();
    Console.WriteLine();

    switch (input)
    {
        case "1": VariablesDemo.Run(); break;
        case "2": StringsDemo.Run(); break;
        case "3": ControlFlowDemo.Run(); break;
        case "4": LoopsDemo.Run(); break;
        case "5": MethodsDemo.Run(); break;
        case "6": CollectionsDemo.Run(); break;
        case "7": PersonDemo.Run(); break;
        case "0":
        case null:
            return;
        default:
            Console.WriteLine("Unknown choice.");
            break;
    }
}
