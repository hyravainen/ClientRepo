namespace t1
{
  
    public class Person
    {
        public string Name { get; private set; }
        public int BirthYear { get; private set; }

        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        public int GetAge(int currentYear)
        {
           return currentYear - BirthYear;
        }


        public override string ToString()
        {

            return $"{Name} (b. {BirthYear})";
        }
    }
}
