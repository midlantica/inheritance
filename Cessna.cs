using System;

public class Cessna : Vehicle
{
  public override string Name { get; set; } = "Cessna";
  public double FuelCapacity { get; set; }

  public void RefuelTank()
  {
    Console.WriteLine("Refuel tank");
  }

  public override void Drive()
  {
    Console.WriteLine($"The {Name} goes Zoooooom!");
    Moving = true;
  }
}
