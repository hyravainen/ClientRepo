namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Person List ===\n");

            int currentYear = 2026;


            List<Person> people = new List<Person>();
            people.Add(new Person("Taneli Kummeli", 1982));
            people.Add(new Person("Ville Kuusisto", 2008));
            people.Add(new Person("Jari Mattila", 1943));

            foreach(Person person in people)
            {
                Console.WriteLine($" {person} - Age: {person.GetAge(currentYear)}");
            }

            Console.WriteLine("\nDone!");
        }
    }
}
