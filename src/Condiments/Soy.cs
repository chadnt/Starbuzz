using Starbuzz.Beverages;
using System;
using System.Collections.Generic;

namespace Starbuzz.Condiments
{
  public class Soy : CondimentDecorator
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.10 },
      { Size.Grande, 0.15 },
      { Size.Venti, 0.20 },
    };

    public Soy(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Soy";

    public override double Cost => beverage.Cost + Prices[Size];

  }
}