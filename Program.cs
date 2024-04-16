using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace WorkingWithThreads;

class Program
{
    static void Main(string[] args)
    {
        // Creating car objects
        CarRace car1 = new CarRace("Car 1");
        CarRace car2 = new CarRace("Car 2");
        CarRace car3 = new CarRace("Car 3");

        // Starting race
        Console.WriteLine("The race is starting!");
        Thread car1Thread = new Thread(car1.Drive);
        Thread car2Thread = new Thread(car2.Drive);
        Thread car3Thread = new Thread(car3.Drive);
        car1Thread.Start();
        car2Thread.Start();
        car3Thread.Start();

        // User input to print status
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "status")
            {
                Console.WriteLine($"Status:\n{car1.Name}: {car1.Distance} km, Speed: {car1.Speed} km/h\n{car2.Name}: {car2.Distance} km, Speed: {car2.Speed} km/h\n{car3.Name}: {car3.Distance} km, Speed: {car3.Speed} km/h");
            }
        }

    }
}

