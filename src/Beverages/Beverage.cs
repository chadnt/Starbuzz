using Starbuzz.Condiments;

namespace Starbuzz.Beverages
{
  public abstract class Beverage
  {
    public virtual Size Size { get; set; } = Size.Tall;

    public virtual string Description { get; } = "Unknown Beverage";

    public abstract double Cost { get; }
  }
}