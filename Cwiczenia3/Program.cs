using Cwiczenia3;


Ship ship = new("Voyager", 25, 10, 500000);
Console.WriteLine(ship);
    
Container bananaContainer = new RefrigeratedContainer(5000, "Bananas", -5);
Container fuelContainer = new LiquidContainer(8000, true);
Container milkContainer = new LiquidContainer(10000, false);
Container heliumContainer = new GasContainer(2000, 100);

milkContainer.Unload();
    
ship.LoadContainer(bananaContainer);
ship.LoadContainer(fuelContainer);
ship.LoadContainer(milkContainer);
ship.LoadContainer(heliumContainer);

Console.WriteLine(ship);

ship.UnloadContainer("KON-C-1");
ship.UnloadContainer("KON-L-2");
ship.UnloadContainer("KON-G-4");

Console.WriteLine(ship);

    
try
{ 
    fuelContainer.Load(1000);
}
catch (Exception e)
{ 
    Console.WriteLine(e.Message);
}
