using System;
using System.Threading;

namespace WorkingWithThreads
{
    // CarRace class representing a single car in the race
    public class CarRace
	{
        // Properties of the car
        public string Name { get; }
        public int Distance { get; private set; }
        public int Speed { get; private set; }
        public bool HasProblem { get; private set; }

        // Constructor to initialize the car
        public CarRace(string name)
        {
            Name = name;
            Distance = 0;
            Speed = 120;
            HasProblem = false;
        }
    }
}

