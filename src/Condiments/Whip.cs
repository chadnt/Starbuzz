using Starbuzz.Beverages;
using System;
using System.Collections.Generic;

namespace Starbuzz.Condiments
{
  public class Whip : CondimentDecorator
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.05 },
      { Size.Grande, 0.10 },
      { Size.Venti, 0.20 },
    };

    public Whip(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Whip";

    public override double Cost => beverage.Cost + Prices[Size];

  }
}