using System;
using System.Threading;

namespace WorkingWithThreads
{
    // CarRace class representing a single car in the race
    public class CarRace
	{
        // Properties of the car
        public string Name { get; set; }
        public double Distance { get; set; }
        public double Speed { get; set; }
        private readonly object _lock = new object(); // Lock object for synchronization




        // Constructor to initialize the car
        public CarRace(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }

        // To generate status on finishing race
        public void Drive()
        {

            // Start the race
            Console.WriteLine($"{Name} starts the race!");

            // Loop until the car reaches the finish line
            while (Distance < 10)
            {
                // Simulate running
                Thread.Sleep(1000); // Simulate time passing (1 second)

                // Update distance (in km) based on speed
                lock (_lock)
                {
                    Distance += Speed / 360;
                }

                // Check for random events
                ProblemChecker();
            }

            // Car has finished the race
            Console.WriteLine($"{Name} has finished the race!");
        }


        // Method to simulate the car's movement affected by problems and
        private void ProblemChecker()
        {
            Random ranDom = new Random();

            
                if (ranDom.Next(1, 51) == 1) // Out of gas
                {
                    Console.WriteLine($"{Name} has run out of gas and needs to refuel.");
                    Thread.Sleep(30000); // Stop for 30 seconds
                }
                else if (ranDom.Next(1, 51) <= 2) // Puncture
                {
                    Console.WriteLine($"{Name} has a puncture and needs to change the tire.");
                    Thread.Sleep(20000); // Stop for 20 seconds
                }
                else if (ranDom.Next(1, 51) <= 5) // Bird on the windshield
                {
                    Console.WriteLine($"{Name} has a bird on the windshield and needs to wash it.");
                    Thread.Sleep(10000); // Stop for 10 seconds
                }
                else if (ranDom.Next(1, 51) <= 10) // Engine failure
                {
                    Console.WriteLine($"{Name} has encountered engine failure. Speed reduced by 1 km/h.");
                    lock (_lock)
                    {
                        Speed -= 1;
                    }
                }

            
        }
    }
}

