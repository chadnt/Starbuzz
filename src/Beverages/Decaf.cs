using System.Collections.Generic;

namespace Starbuzz.Beverages
{
  public class Decaf : Beverage
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.95 },
      { Size.Grande, 1.05 },
      { Size.Venti, 1.15 },
    };

    public override string Description { get; } = "Decaf";

    public override double Cost => Prices[Size];

  }
}