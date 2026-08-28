namespace t1
{
    /// <summary>
    /// Represents a person with a name and birth year.
    /// </summary>
    public class Person
    {
        public string Name { get; private set; }
        public int BirthYear { get; private set; }

        /// <summary>
        /// Creates a new Person with the given name and birth year.
        /// </summary>
        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        /// <summary>
        /// Calculates the person's age based on the given current year.
        /// For example, a person born in 2003 has age 23 in 2026.
        /// </summary>
        public int GetAge(int currentYear)
        {
            // TODO: Task 1 - Implement GetAge
            // - Return the difference between currentYear and BirthYear.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a string in the format "Maija Meikalainen (b. 2003)".
        /// The Finnish version uses "s." and the English version uses "b."
        /// — use "b." here.
        /// </summary>
        public override string ToString()
        {
            // TODO: Task 2 - Implement ToString
            // - Return a string in the format: "Name (b. BirthYear)"
            // - Example: "Jane Doe (b. 2003)"
            throw new NotImplementedException();
        }
    }
}
