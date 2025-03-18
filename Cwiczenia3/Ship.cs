namespace Cwiczenia3;

public class Ship
{
    public string Name { get; }
    public double MaxSpeed { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }

    private List<Container> containers = new();

    public Ship(string name, double maxSpeed, int maxContainers, double maxWeight)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (containers.Count >= MaxContainers || containers.Sum(c => c.MaxLoad) + container.MaxLoad > MaxWeight)
            throw new Exception("Statek nie może przyjąć więcej kontenerów!");
        containers.Add(container);
    }

    public void UnloadContainer(string serialNumber)
    {
        var container = containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            containers.Remove(container);
        }
    }

    public override string ToString()
    {
        return $"Statek {Name} - Max Speed: {MaxSpeed} km/h, Containers: {containers.Count}/{MaxContainers}";
    }
}