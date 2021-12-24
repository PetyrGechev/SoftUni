using System;
using System.Collections.Generic;

namespace Presents.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void CtorPresent()
        {
            Present present = new Present("d", 2.4);
            Assert.That(present.Name=="d");
            Assert.That(present.Magic==2.4);
        }
        [Test]
        public void Create1()
        {
            Bag bag = new Bag();
            Present present = null;
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));

        }
        [Test]
        public void Create2()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));

        }
        [Test]
        public void Create3()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            string result=bag.Create(present);
            Assert.That(result== $"Successfully added present d.");

        }
        [Test]
        public void Remove1()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            bag.Create(present);
            Assert.IsTrue(bag.Remove(present));
            

        }
        [Test]
        public void Remove2()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            Present present2 = new Present("2", 2.4);
            bag.Create(present);
            Assert.IsFalse(bag.Remove(present2));


        }
        [Test]
        public void GetPresentLeast()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            Present present2 = new Present("2", 1.4);
            Present present3 = new Present("222", 0.4);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            var leastPresent = bag.GetPresentWithLeastMagic();
            Assert.That(leastPresent == present3);


        }
        [Test]
        public void GetPresentName()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
            Present present2 = new Present("2", 1.4);
            Present present3 = new Present("222", 0.4);
            bag.Create(present);
            bag.Create(present2);
            bag.Create(present3);
            var leastPresent = bag.GetPresent("d");
            Assert.That(leastPresent == present);
        }
        [Test]
        public void GetPresents()
        {
            Bag bag = new Bag();
            Present present = new Present("d", 2.4);
           
            bag.Create(present);
            
            

            var presenst = bag.GetPresents();

            foreach (var VARIABLE in presenst)
            {
                Assert.That(present==VARIABLE);
            }
        }
    }
}
