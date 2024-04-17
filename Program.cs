using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace WorkingWithThreads;

class Program
{
    static void Main(string[] args)
    {
        // Creating car objects
        CarRace car1 = new CarRace("Toyota", 120);
        CarRace car2 = new CarRace("Audi", 120);
        CarRace car3 = new CarRace("Hummer", 120);

        // Starting race
        Console.WriteLine("The race is starting!");
        Thread car1Thread = new Thread(car1.Drive);
        Thread car2Thread = new Thread(car2.Drive);
        Thread car3Thread = new Thread(car3.Drive);
        car1Thread.Start();
        car2Thread.Start();
        car3Thread.Start();

        // User input to print status
        Console.WriteLine("Type 's' to get current race status: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "s")
            {
                Console.WriteLine($"Status:\n{car1.Name}: {car1.Distance:F2} km, Speed: {car1.Speed} km/h\n{car2.Name}: {car2.Distance:F2} km, Speed: {car2.Speed} km/h\n{car3.Name}: {car3.Distance:F2} km, Speed: {car3.Speed} km/h");
            }
            else
            {
                Console.WriteLine("Invalid command. Type 's' to get current race status:");
            }

        }

    }
}

