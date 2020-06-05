using System;
using System.Collections.Generic;
using System.Linq;
public class Vehicle
{
  public virtual string MainColor { get; set; }
  public string MaximumOccupancy { get; set; }
  public bool Moving = false;

  public virtual string Name { get; set; }
  public string Direction = "forward";
  public virtual void Turn(string direction)

  {
    if (Moving != true)
    {
      Console.WriteLine($"The {Name} can't turn if it's not moving!");
    }
    else
    {
      Console.WriteLine($"The {Name} is now moving {direction}");
      Direction = direction;
    }
  }

  public virtual void Drive()
  {
    Moving = true;
    Console.WriteLine($"The {Name} goes Vrooom!");
  }

  public virtual void Stop()
  {
    Moving = false;
    Console.WriteLine($"The {Name} stops like Erhhh!");
  }

  public virtual void Turn()
  {
    Direction = "right";
    Console.WriteLine($"The {Name} stops like Erhhh!");
  }

}
