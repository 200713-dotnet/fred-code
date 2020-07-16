using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  internal class Startup
  {
    internal Pizza CreatePizza(string size, string crust, List<string> toppings)
    {
      return new Pizza(size, crust, toppings);

      // pizza.SizeP = size;
      // pizza.Crust = crust;
      // pizza.Toppings.AddRange(toppings);
    }
  }
}