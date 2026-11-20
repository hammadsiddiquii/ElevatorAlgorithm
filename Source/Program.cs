Console.WriteLine("ElevatorAlgorithm console application.");

Building building = new Building(10, 1);

Elevator elevator = new Elevator(500);

Person person1 = new Person("Alice", 150, 1);
Person person2 = new Person("Bob", 200, 4);

elevator.AddPassenger(person1);
elevator.AddPassenger(person2);

