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

        // Method to simulate the car's movement affected by problems and
        // to generate status on finishing race as well
        public void Drive()
        {
            Random random = new Random();

            // Loop until the car reaches the finish line
            while (Distance < 10000)
            {
                // Check if the car has a problem
                if (!HasProblem)
                {
                    // Randomly generate an event every 30 seconds
                    if (random.Next(1, 51) == 1) // Out of gas
                    {
                        Console.WriteLine($"{Name} has run out of gas and needs to refuel.");
                        Thread.Sleep(30000); // Stop for 30 seconds
                    }
                    else if (random.Next(1, 51) <= 2) // Puncture
                    {
                        Console.WriteLine($"{Name} has a puncture and needs to change the tire.");
                        Thread.Sleep(20000); // Stop for 20 seconds
                    }
                    else if (random.Next(1, 51) <= 5) // Bird on the windshield
                    {
                        Console.WriteLine($"{Name} has a bird on the windshield and needs to wash it.");
                        Thread.Sleep(10000); // Stop for 10 seconds
                    }
                    else if (random.Next(1, 51) <= 10) // Engine failure
                    {
                        Console.WriteLine($"{Name} has encountered engine failure. Speed reduced by 1 km/h.");
                        Speed -= 1;
                    }

                    // Drive the car
                    Distance += Speed / 3600; // Convert speed from km/h to km/s
                    Console.WriteLine($"{Name} is at {Distance} km.");
                    Thread.Sleep(1000); // Wait for 1 second
                }
                else
                {
                    // Car has a problem, cannot move
                    Thread.Sleep(1000); // Wait for 1 second
                }
            }

            // Car has finished the race
            Console.WriteLine($"{Name} has finished the race!");
        }
    }
}

