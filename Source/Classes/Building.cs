public class Building
{
    public int NumberOfFloors { get; set; }
    public int NumberOfElevators { get; set; }

    public Building(int numberOfFloors, int numberOfElevators)
    {
        NumberOfFloors = numberOfFloors;
        NumberOfElevators = numberOfElevators;
    }
}