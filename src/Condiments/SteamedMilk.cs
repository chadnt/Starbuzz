using Starbuzz.Beverages;
using System;

namespace Starbuzz.Condiments
{
  public class SteamedMilk : CondimentDecorator
  {
    private Beverage beverage;

    public SteamedMilk(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, SteamedMilk";

    public override double Cost => beverage.Cost + 0.10;

  }
}