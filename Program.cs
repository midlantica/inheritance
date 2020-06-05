using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero ();
      Tesla modelS = new Tesla ();
      Cessna mx410 = new Cessna ();
      Ram realFastModel = new Ram ();

      fxs.Drive();
      modelS.Drive();
      mx410.Drive();
      realFastModel.Drive();
      realFastModel.Stop();

      string ramColor = "Red";
      Console.WriteLine($"My new Dodge is {ramColor}");
    }

  }
}
