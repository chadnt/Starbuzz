using System.Collections.Generic;

namespace Starbuzz.Beverages
{
  public class HouseBlend : Beverage
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.79 },
      { Size.Grande, 0.89 },
      { Size.Venti, 0.99 },
    };

    public override string Description { get; } = "House Blend";

    public override double Cost => Prices[Size];

  }
}