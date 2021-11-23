using ExtendedDatabase;
using NUnit.Framework;



namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Ctor_AddinitialPeopleToDataBase()
        {
            var people = new Person[5];
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person(i, $"Name_{i}");

            }

            extendedDatabase = new ExtendedDatabase.ExtendedDatabase(people);
            Assert.That(extendedDatabase.Count,Is.EqualTo(people.Length));
            foreach (var person in people)
            {
                Person personFromDb = extendedDatabase.FindById(person.Id);
                Assert.That(person, Is.EqualTo(personFromDb));                 /////////  ! ! ! !
            }
        }

    }
}