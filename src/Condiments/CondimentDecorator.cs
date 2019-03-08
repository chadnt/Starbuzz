using Starbuzz.Beverages;

namespace Starbuzz.Condiments
{
  public abstract class CondimentDecorator : Beverage
  {
    // require condiment decorators to implement Description get accessor.
    public override abstract string Description { get; }

  }
}