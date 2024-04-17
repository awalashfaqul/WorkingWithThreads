# Car Race Simulation

This project is a simple car race simulation implemented in C# using threads. The goal is to demonstrate multi-threading in action by simulating a race among multiple cars. Each car is represented by the `CarRace` class, and the race itself is orchestrated in the `Program` class.

## Features

- **Multi-Threading**: Each car in the race runs on its own thread, allowing them to move independently and concurrently.
- **Random Events**: Various random events, such as running out of gas, punctures, bird on the windshield, and engine failure, are simulated to add unpredictability and challenge to the race.
- **Status Updates**: Users can request status updates during the race to see the current distance covered and speed of each car.

## Project Structure

### `CarRace.cs`

This file contains the definition of the `CarRace` class, which represents a single car in the race. It includes properties such as `Name`, `Distance`, and `Speed`, as well as methods for driving and handling random events.

### `Program.cs`

This file contains the `Main` method where the race is initialized. It creates instances of `CarRace`, starts their respective threads, and provides a simple user interface to request status updates during the race.

