using System.Collections.Generic;

namespace Starbuzz.Beverages
{
  public class Espresso : Beverage
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 1.69 },
      { Size.Grande, 1.99 },
      { Size.Venti, 2.29 },
    };

    public override string Description { get; } = "Espresso";

    public override double Cost => Prices[Size];

  }
}