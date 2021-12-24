using System;
using NUnit.Framework;



namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase();
        }

        [Test]
        public void Ctor_AddinitialPeopleToDataBase()
        {
            var people = new Person[5];
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person(i, $"Name_{i}");

            }

            extendedDatabase = new ExtendedDatabase(people);
            Assert.That(extendedDatabase.Count,Is.EqualTo(people.Length));
            foreach (var person in people)
            {
                Person personFromDb = extendedDatabase.FindById(person.Id);
                Assert.That(person, Is.EqualTo(personFromDb));                 
            }
        }
        [Test]
        public void Ctor_ThrowsExceptionWhenCapacityIsExceeded()
        {
            var people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Name_{i}");

            }

            Assert.Throws<ArgumentException>(() => extendedDatabase = new ExtendedDatabase(people));
        }
        [Test]
        public void Add_ShoudNotAddMoreThan16Elements()
        {
            var people = new Person[16];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Name_{i}");

            }

            extendedDatabase = new ExtendedDatabase(people);
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(new Person(16,"Name_16")));
        }
        [Test]
        public void Add_ShoudNotAddPersonWithSameID()
        {
            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(1, "Babun");
            
            extendedDatabase = new ExtendedDatabase(personOne);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(personTwo));
        }
        [Test]
        public void Add_ShoudNotAddPersonWithSameName()
        {
            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(12, "Gogi");

            extendedDatabase = new ExtendedDatabase(personOne);

            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Add(personTwo));
        }
        [Test]
        public void Add_ShoudAddPersonToDB()
        {
            Person personOne = new Person(1, "Gogi");
          

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);

            Assert.That(extendedDatabase.Count,Is.EqualTo(1));
        }

        [Test]
        public void Remove_ThrowsExceptionWhenDBIsEmpty()
        {
            
            extendedDatabase = new ExtendedDatabase();
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Remove());

        }
        [Test]
        public void Remove_ShoudRemoveItemFromDB()
        {

            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(2, "Kiro");


            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            extendedDatabase.Add(personTwo);
            extendedDatabase.Remove();

            Assert.That(extendedDatabase.Count, Is.EqualTo(1));
            Person person = extendedDatabase.FindByUsername("Gogi");
            Assert.That(person,Is.EqualTo(personOne));

        }
        [TestCase("")]
        [TestCase(null)]

        public void FindByUsername_ThrowsExpectionWhenNameisEmptyOrNull(string name)
        {

            Person personOne = new Person(1, "Gogi");
            
            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(name));

        }
        [TestCase("Koko")]
        [TestCase("Gigi")]

        public void FindByUsername_ThrowsExpectionWhenCantFindTheName(string name)
        {

            Person personOne = new Person(1, "Gogi");

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername(name));

        }
        [Test]
        public void FindByUsername_ShoudFindTheRightPersonByName()
        {

            Person personOne = new Person(1, "Gogi");

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            Person personFromDb = extendedDatabase.FindByUsername("Gogi");
            Assert.That(personOne,Is.EqualTo(personFromDb));

        }
        [Test]
        public void FindByID_ShoudFindTheRightPersonByID()
        {

            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(2, "Kiro");

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            extendedDatabase.Add(personTwo);
            Person personFromDb = extendedDatabase.FindById(1);
            Assert.That(personOne, Is.EqualTo(personFromDb));

        }
        [Test]
        public void FindByID_ThrowsExpectionWhenIDisNegative()
        {

            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(2, "Kiro");

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            extendedDatabase.Add(personTwo);
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(-1));

        }
        [Test]
        public void FindByID_ThrowsExpectionWhenCantFindThePerson()
        {

            Person personOne = new Person(1, "Gogi");
            Person personTwo = new Person(2, "Kiro");

            extendedDatabase = new ExtendedDatabase();
            extendedDatabase.Add(personOne);
            extendedDatabase.Add(personTwo);
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(3));

        }

    }
}