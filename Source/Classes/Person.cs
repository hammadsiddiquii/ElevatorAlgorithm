public class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int CurrentFloor { get; set; } = 0;

    public Person(string name, int weight, int currentFloor = 0)
    {
        Name = name;
        Weight = weight;
        CurrentFloor = currentFloor;
    }

    public void CallElevator(Elevator elevator)
    {
        
            Console.WriteLine($"{Name} called the elevator on floor {CurrentFloor}.");
            elevator.MoveToFloor(destinationFloor);
            CurrentFloor = destinationFloor;
            Console.WriteLine($"{Name} has exited the elevator on floor {CurrentFloor}.");
            elevator.RemovePassenger(this);
        }
        else
        {
            Console.WriteLine($"{Name} cannot enter the elevator due to weight limit.");
        }
    }
}