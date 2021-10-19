using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TheRace
{
    class Race
    {
        public Race(string name,int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        private List<Racer> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return data.Count;
            }

        }
        public void Add(Racer Racer)
        {
            if (Capacity>data.Count)
            {
                data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            var racerName = data.FirstOrDefault(x => x.Name == name);
            if (racerName==null)
            {
                return false;
            }

            Racer racerToRemove = data.FirstOrDefault(x => x.Name == name);
            data.Remove(racerToRemove);

            return true;
        }

        public Racer GetOldestRacer()
        {
            Racer oldersRacer = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldersRacer;
        }

        public Racer GetRacer(string name)
        {
            return data.FirstOrDefault(x => x.Name == name);

        }

        public Racer GetFastestRacer()
        {

            return data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();

        }

    }
}
