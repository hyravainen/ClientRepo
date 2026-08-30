namespace t1
{
    //luodaan luokka
    public class Person
    {
        public string Name { get; private set; }
        public int BirthYear { get; private set; }

        //luodaan konstuktori
        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        //lasketaan vuosien erotus
        public int GetAge(int currentYear)
        {
           return currentYear - BirthYear;
        }

        //tehdään yhteinen lauseke
        public override string ToString()
        {

            return $"{Name} (b. {BirthYear})";
        }
    }
}
