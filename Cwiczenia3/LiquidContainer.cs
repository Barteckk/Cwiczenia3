namespace Cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; }

    public LiquidContainer(double maxLoad, bool isHazardous) : base("L", maxLoad)
    {
        IsHazardous = isHazardous;
    }

    public override void Load(double weight)
    {
        double limit = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (CurrentLoad + weight > limit)
        {
            NotifyHazard("Próba przeładowania niebezpiecznego ładunku!");
            throw new Exception("OverfillException: Przekroczono limit dla ładunku niebezpiecznego!");
        }
        base.Load(weight);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[HAZARD] {SerialNumber}: {message}");
    }
}