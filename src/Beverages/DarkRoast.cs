using System.Collections.Generic;

namespace Starbuzz.Beverages
{
  public class DarkRoast : Beverage
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.99 },
      { Size.Grande, 1.09 },
      { Size.Venti, 1.19 },
    };

    public override string Description { get; } = "Dark Roast";

    public override double Cost => Prices[Size];

  }
}