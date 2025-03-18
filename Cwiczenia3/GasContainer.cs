namespace Cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    public double pressure { get; }

    public GasContainer(double MaxLoad, double Pressure) : base("G", MaxLoad)
    {
        pressure = Pressure;
    }

    public override void Unload()
    {
        CurrentLoad *= 0.05;
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[HAZARD] {SerialNumber}: {message}");
    }
}