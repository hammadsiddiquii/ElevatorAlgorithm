public class Elevator
{
    public int CurrentFloor { get; set; }
    public int Capacity { get; set; }
    public List<Person> Passengers { get; set; }
    public List<int> DestinationFloors { get; set; }
    public Elevator(int capacity)
    {
        CurrentFloor = 0;
        Capacity = capacity;
        Passengers = new List<Person>();
        DestinationFloors = new List<int>() ;
    }

    public void MoveToFloor(int floor)
    {
        CurrentFloor = floor;
    }
    
    public void PessengerCallToFloor(int floor)
    {
        if (!DestinationFloors.Contains(floor))
        {
            DestinationFloors.Add(floor);
        }
    }

    public bool AddPassenger(Person person)
    {
        if (Passengers.Sum(p => p.Weight) <= Capacity)
        {
            Passengers.Add(person);
            return true;
        }
        return false;
    }

    public void RemovePassenger(Person person)
    {
        Passengers.Remove(person);
    }
}