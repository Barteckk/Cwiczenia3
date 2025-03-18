namespace Cwiczenia3;

public class RefrigeratedContainer : Container
{
    public string ProductType {get;}
    public double RequiredTemperature { get; }

    public RefrigeratedContainer(double MaxLoad, string productType, double requiredTemperature) : base("C", MaxLoad)
    {
        ProductType = productType;
        RequiredTemperature = requiredTemperature;
    }
}