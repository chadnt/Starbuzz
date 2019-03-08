using Starbuzz.Beverages;
using Starbuzz.Condiments;
using System;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
    {
        
      Beverage beverage = new Espresso();
      Display(beverage);

      beverage = new DarkRoast();
      beverage = new Mocha(beverage);
      beverage = new Mocha(beverage);
      beverage = new Whip(beverage);
      Display(beverage);

      beverage = new HouseBlend();
      beverage = new Soy(beverage);
      beverage = new Mocha(beverage);
      beverage = new Whip(beverage);
      Display(beverage);

    }

    private static void Display(Beverage beverage)
    {
      Console.WriteLine($"{beverage.Description}: ${beverage.Cost}");
    }
  }
}
