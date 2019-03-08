using Starbuzz.Beverages;
using System;

namespace Starbuzz.Condiments
{
  public class Soy : CondimentDecorator
  {
    private Beverage beverage;

    public Soy(Beverage beverage)
    {
      this.beverage = beverage ?? throw new ArgumentNullException();
    }

    public override string Description => $"{beverage.Description}, Soy";

    public override double Cost => beverage.Cost + 0.15;

  }
}