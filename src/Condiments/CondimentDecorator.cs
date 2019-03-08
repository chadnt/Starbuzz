using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
  public abstract class CondimentDecorator : Beverage
  {
    protected Beverage beverage;

    // require condiment decorators to implement Description get accessor.
    public override abstract string Description { get; }

    public override Size Size
    {
      get { return beverage.Size; }
      set { beverage.Size = value; }
    }

  }
}