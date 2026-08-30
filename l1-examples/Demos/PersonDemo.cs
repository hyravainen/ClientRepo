namespace L1Examples.Demos;

// A worked example of a class: fields as properties, constructor,
// a method, and an overridden ToString().
// This is deliberately the SAME shape as the in-class task 1 (t1),
// so students see one full solution before writing their own.
public static class PersonDemo
{
    public static void Run()
    {
        Console.WriteLine("--- Person class ---");

        // Build a list of persons.
        List<Person> people =
        [
            new Person("Alice",  2003),
            new Person("Bob",    1998),
            new Person("Cara",   2010),
        ];

        // Print them all — ToString() is called automatically by WriteLine.
        int currentYear = 2026;
        foreach (Person p in people)
        {
            Console.WriteLine($"{p}  — age {p.GetAge(currentYear)}");
        }
    }
}

// A plain class with properties, a constructor, a method and ToString().
public class Person
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    public int GetAge(int currentYear) => currentYear - BirthYear;

    public override string ToString() => $"{Name} (b. {BirthYear})";
}
