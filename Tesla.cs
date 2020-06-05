using System;

public class Tesla : Vehicle
{
  public override string Name { get; set; } = "Tesla";
  public double BatteryKWh { get; set; }

  public void ChargeBattery()
  {
    // method definition omitted
  }
}
