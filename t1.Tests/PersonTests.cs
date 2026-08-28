using Xunit;

namespace t1.Tests
{
    public class PersonConstructorTests
    {
        [Fact]
        public void Constructor_SetsNameCorrectly()
        {
            var person = new Person("Alice", 2001);

            Assert.Equal("Alice", person.Name);
        }

        [Fact]
        public void Constructor_SetsBirthYearCorrectly()
        {
            var person = new Person("Alice", 2001);

            Assert.Equal(2001, person.BirthYear);
        }
    }

    public class GetAgeTests
    {
        [Fact]
        public void GetAge_BornIn2001_CurrentYear2026_Returns25()
        {
            var person = new Person("Alice", 2001);

            int age = person.GetAge(2026);

            Assert.Equal(25, age);
        }

        [Fact]
        public void GetAge_BornIn2000_CurrentYear2000_ReturnsZero()
        {
            var person = new Person("Bob", 2000);

            int age = person.GetAge(2000);

            Assert.Equal(0, age);
        }

        [Fact]
        public void GetAge_BornIn1990_CurrentYear2026_Returns36()
        {
            var person = new Person("Carol", 1990);

            int age = person.GetAge(2026);

            Assert.Equal(36, age);
        }
    }

    public class ToStringTests
    {
        [Fact]
        public void ToString_ReturnsCorrectFormat()
        {
            var person = new Person("Jane Doe", 2003);

            string result = person.ToString();

            Assert.Equal("Jane Doe (b. 2003)", result);
        }

        [Fact]
        public void ToString_DifferentPerson_ReturnsCorrectFormat()
        {
            var person = new Person("Matti Virtanen", 1995);

            string result = person.ToString();

            Assert.Equal("Matti Virtanen (b. 1995)", result);
        }
    }
}
