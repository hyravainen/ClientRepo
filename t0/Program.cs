namespace t0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Refresher ===\n");

            // --- Part 1: Variables and types ---
            Console.WriteLine("--- Part 1: Variables and types ---");

            string courseName = "Client-Side Programming";
            int year = 2026;
            double pi = 3.14159;
            bool isFirstLecture = true;

            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Pi: {pi:F2}");
            Console.WriteLine($"First lecture: {isFirstLecture}");

            // --- Part 2: Arrays and loops ---
            Console.WriteLine("\n--- Part 2: Arrays and loops ---");

            string[] languages = { "C#", "Java", "Python", "JavaScript" };
            Console.WriteLine("Programming languages:");
            foreach (string lang in languages)
            {
                Console.WriteLine($"  - {lang}");
            }

            // --- Part 3: Methods ---
            Console.WriteLine("\n--- Part 3: Methods ---");

            int sum = Add(10, 25);
            Console.WriteLine($"10 + 25 = {sum}");

            string greeting = Greet("World");
            Console.WriteLine(greeting);

            double average = Average(new int[] { 4, 8, 15, 16, 23, 42 });
            Console.WriteLine($"Average: {average:F1}");

            // --- Part 4: Conditions ---
            Console.WriteLine("\n--- Part 4: Conditions ---");

            int temperature = 22;
            string description = DescribeTemperature(temperature);
            Console.WriteLine($"{temperature} C is {description}");

            // --- Part 5: Your turn ---
            Console.WriteLine("\n--- Part 5: Exercises ---");

            // Uncomment these lines after implementing the methods in Exercises.cs:
            // Console.WriteLine($"5! = {Exercises.Factorial(5)}");
            // Console.WriteLine($"Reversed: {Exercises.ReverseString("hello")}");
            // Console.WriteLine($"Vowels in 'programming': {Exercises.CountVowels("programming")}");

            Console.WriteLine("\nDone!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        static double Average(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }

        static string DescribeTemperature(int celsius)
        {
            if (celsius < 0)
                return "freezing";
            else if (celsius < 10)
                return "cold";
            else if (celsius < 20)
                return "cool";
            else if (celsius < 30)
                return "warm";
            else
                return "hot";
        }
    }
}
