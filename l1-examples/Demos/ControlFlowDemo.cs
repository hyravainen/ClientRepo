namespace L1Examples.Demos;

// Control flow: if / else if / else, switch statement, switch expression.
public static class ControlFlowDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Control flow ---");

        int[] ages = { 12, 25, 70 };

        foreach (int age in ages)
        {
            // Classic if / else if / else.
            string category;
            if (age < 18)
                category = "Minor";
            else if (age < 65)
                category = "Adult";
            else
                category = "Senior";

            Console.WriteLine($"if-chain    : age {age} -> {category}");
        }

        Console.WriteLine();

        foreach (int age in ages)
        {
            // Switch expression (C# 8+) — same logic, one expression.
            string category = age switch
            {
                < 18 => "Minor",
                < 65 => "Adult",
                _    => "Senior"
            };
            Console.WriteLine($"switch expr : age {age} -> {category}");
        }

        // Switch statement — matches by value, with fall-through prevention.
        Console.WriteLine();
        string day = "Sat";
        switch (day)
        {
            case "Mon":
            case "Tue":
            case "Wed":
            case "Thu":
            case "Fri":
                Console.WriteLine($"{day} is a work day.");
                break;
            case "Sat":
            case "Sun":
                Console.WriteLine($"{day} is the weekend.");
                break;
            default:
                Console.WriteLine("Unknown day.");
                break;
        }
    }
}
