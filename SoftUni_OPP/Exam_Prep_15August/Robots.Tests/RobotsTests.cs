using NUnit.Framework;
using System.Linq;
namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {
        [Test]
        public void CtorCapacity()
        {
            RobotManager robot = new RobotManager(4);

            Assert.That(robot.Capacity==4);
        }
        [Test]
        public void Ctor2()
        {
            RobotManager robots = new RobotManager(4);
            
            Assert.IsNotNull(robots);
        }
        [Test]
        public void Capacity()
        {
            RobotManager robots = null;
            

            Assert.Throws<ArgumentException>(() =>  robots = new RobotManager(-2));
        }
        [Test]
        public void count()
        {
            RobotManager robots = new RobotManager(4);

            robots.Add(new Robot("n",2));
            robots.Add(new Robot("s",33));
            robots.Add(new Robot("fd",12));
            Assert.That(robots.Count==3);
        }
        [Test]
        public void add()
        {
            RobotManager robots = new RobotManager(4);

            robots.Add(new Robot("n", 2));
          
            robots.Add(new Robot("fd", 12));
            Assert.Throws<InvalidOperationException>(() => robots.Add(new Robot("n", 44)));
        }
        [Test]
        public void add2()
        {
            RobotManager robots = new RobotManager(2);

            robots.Add(new Robot("n", 2));

            robots.Add(new Robot("fd", 12));
            Assert.Throws<InvalidOperationException>(() => robots.Add(new Robot("dad", 44)));
        }
        [Test]
        public void Remove()
        {
            RobotManager robots = new RobotManager(2);

            robots.Add(new Robot("n", 2));

            robots.Add(new Robot("fd", 12));
            Assert.Throws<InvalidOperationException>(() => robots.Remove("fwww"));
        }
        [Test]
        public void Remove2()
        {
            RobotManager robots = new RobotManager(2);

            robots.Add(new Robot("n", 2));

            robots.Add(new Robot("fd", 12));
            robots.Remove("fd");
            Assert.That(robots.Count==1);

        }
        [Test]
        public void Work()
        {
            RobotManager robots = new RobotManager(2);

            Robot robot = new Robot("n", 20);

            robots.Add(robot);

            robots.Work("n","bubu",10);
           
            Assert.That(robot.Battery==10);
        }
        [Test]
        public void Work2()
        {
            RobotManager robots = new RobotManager(2);

            Robot robot = new Robot("n", 20);

            robots.Add(robot);

            
            Assert.Throws<InvalidOperationException>(()=> robots.Work("22", "bubu", 10));
        }
        [Test]
        public void Work3()
        {
            RobotManager robots = new RobotManager(2);

            Robot robot = new Robot("n", 20);

            robots.Add(robot);


            Assert.Throws<InvalidOperationException>(() => robots.Work("n", "bubu", 30));
        }
        [Test]
        public void Charge()
        {
            RobotManager robots = new RobotManager(2);

            Robot robot = new Robot("n", 20);

            robots.Add(robot);
            robots.Work("n", "bubu", 10);
            robots.Charge("n");
            Assert.That(robot.Battery==robot.MaximumBattery); 

        }
        [Test]
        public void Charge2()
        {
            RobotManager robots = new RobotManager(2);

            Robot robot = new Robot("n", 20);

            robots.Add(robot);
            robots.Work("n", "bubu", 10);
           
            Assert.Throws<InvalidOperationException>(()=> robots.Charge("bubu"));

        }
    }
}

