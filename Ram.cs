using System;

public class Ram : Vehicle
{
  public override string Name { get; set; } = "Dodge Ram";
  public double FuelCapacity { get; set; }

  public override string MainColor { get; set;  }

  public string ramColor = "Red";
  public void RefuelTank()
  {
  // method definition omitted
  }

  public override void Turn(string direction)
  {
    Console.WriteLine($"The Ram goes {Direction}");
  }

}
