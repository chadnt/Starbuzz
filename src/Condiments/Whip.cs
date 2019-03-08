using Starbuzz.Beverages;
using System;

namespace Starbuzz.Condiments
{
  public class Whip : CondimentDecorator
  {
    private Beverage beverage;

    public Whip(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Whip";

    public override double Cost => beverage.Cost + 0.10;

  }
}