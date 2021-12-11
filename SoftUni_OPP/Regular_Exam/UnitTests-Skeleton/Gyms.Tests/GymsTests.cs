using System;
using NUnit.Framework;

namespace Gyms.Tests
{
    public class GymsTests
    {
        private Gym gym;

        [SetUp]
        public void SetUp()
        {
            gym = new Gym("d", 10);
        }
        [Test]
        public void ctorAtlet()
        {
            Athlete atlet = new Athlete("g");
            Assert.That(atlet.FullName == "g");
            Assert.That(atlet.IsInjured == false);
        }

        [Test]
        public void ctorGym()
        {
            Assert.That(gym.Name == "d");
            Assert.That(gym.Capacity == 10);
        }
        [Test]
        public void ctorGym2()
        {
            Gym thegym = new Gym("dd", 20);
            Athlete atlet = new Athlete("g");
            thegym.AddAthlete(atlet);
            Assert.That(gym.Name == "d");
            Assert.That(thegym.Name == "dd");
            Assert.That(thegym.Capacity == 20);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Name(string name)
        {
            Gym gym1;
            Assert.Throws<ArgumentNullException>(() => gym1 = new Gym(name, 20));
        }
        [TestCase(-2)]
        [TestCase(-9999)]
        public void Capacity(int capacity)
        {
            Gym gym1;
            Assert.Throws<ArgumentException>(() => gym1 = new Gym("dd", capacity));
        }
        [Test]
        public void Count()
        {
            Gym thegym = new Gym("dd", 20);
            Athlete atlet = new Athlete("g");
            thegym.AddAthlete(atlet);
            Assert.That(thegym.Count == 1);

        }
        [Test]
        public void Add()
        {
            Gym thegym = new Gym("dd", 1);
            Athlete atlet = new Athlete("g");
            Athlete atlet2 = new Athlete("dd");
            thegym.AddAthlete(atlet);
            Assert.Throws<InvalidOperationException>(() => thegym.AddAthlete(atlet2));

        }
        [Test]
        public void Remove()
        {
            Gym thegym = new Gym("dd", 3);
            Athlete atlet = new Athlete("g");
            Athlete atlet2 = new Athlete("dd");
            thegym.AddAthlete(atlet);
            thegym.AddAthlete(atlet2);
            thegym.RemoveAthlete("dd");
            Assert.That(thegym.Count == 1);

        }
        [Test]
        public void Remove2()
        {
            Gym thegym = new Gym("dd", 3);
            Athlete atlet = new Athlete("g");
            Athlete atlet2 = new Athlete("dd");
            thegym.AddAthlete(atlet);
            thegym.AddAthlete(atlet2);
            Assert.Throws<InvalidOperationException>(() => thegym.RemoveAthlete(null));

        }
        [Test]
        public void Injure()
        {
            Gym thegym = new Gym("dd", 3);
            Athlete atlet = new Athlete("g");
            Athlete atlet2 = new Athlete("dd");
            thegym.AddAthlete(atlet);
            thegym.AddAthlete(atlet2);
            var injuredAtlete = thegym.InjureAthlete("g");
            Assert.That(injuredAtlete.IsInjured==true);

        }
        [Test]
        public void Injure2()
        {
            Gym thegym = new Gym("dd", 3);
            Athlete atlet = new Athlete("g");
            Athlete atlet2 = new Athlete("dd");
            thegym.AddAthlete(atlet);
            thegym.AddAthlete(atlet2);
            Assert.Throws<InvalidOperationException>(() => thegym.InjureAthlete(null));

        }
        [Test]
        public void Report()
        {
            Gym thegym = new Gym("g", 4);
            Athlete atlet = new Athlete("d");
            Athlete atlet2 = new Athlete("dd");
            Athlete atlet3 = new Athlete("ddd");
            Athlete atlet4 = new Athlete("dddd");
            thegym.AddAthlete(atlet);
            thegym.AddAthlete(atlet2);
            thegym.AddAthlete(atlet3);
            thegym.AddAthlete(atlet4);
            atlet3.IsInjured = true;
            var report = thegym.Report();
            Assert.That(report== "Active athletes at g: d, dd, dddd");
        }


    }




}
