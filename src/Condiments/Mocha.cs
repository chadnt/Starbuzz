using Starbuzz.Beverages;
using System;
using System.Collections.Generic;

namespace Starbuzz.Condiments
{
  public class Mocha : CondimentDecorator
  {
    private Dictionary<Size, double> Prices { get; } = new Dictionary<Size, double>
    {
      { Size.Tall, 0.15 },
      { Size.Grande, 0.20 },
      { Size.Venti, 0.25 },
    };

    public Mocha(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Mocha";

    public override double Cost => beverage.Cost + Prices[Size];

  }
}