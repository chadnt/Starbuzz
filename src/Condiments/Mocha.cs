using Starbuzz.Beverages;
using System;

namespace Starbuzz.Condiments
{
  public class Mocha : CondimentDecorator
  {
    private Beverage beverage;

    public Mocha(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Mocha";

    public override double Cost => beverage.Cost + 0.20;

  }
}