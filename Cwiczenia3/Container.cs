namespace Cwiczenia3;

public abstract class Container
{
    private static int counter = 1;
    public string SerialNumber { get; }
    public double MaxLoad { get; }
    public double CurrentLoad { get; protected set; }

    protected Container(string type, double maxLoad)
    {
        SerialNumber = $"KON-{type}-{counter++}";
        MaxLoad = maxLoad;
    }

    public virtual void Load(double weight)
    {
        if (CurrentLoad + weight > MaxLoad)
            throw new Exception("OverfillExcption: Maksymalna pojemność kontenera przekroczona!");
        
        CurrentLoad += weight;
    }

    public virtual void Unload()
    {
        CurrentLoad = 0;
    }

    public override string ToString() => $"[{SerialNumber}] Load: {CurrentLoad}/{MaxLoad}";
}