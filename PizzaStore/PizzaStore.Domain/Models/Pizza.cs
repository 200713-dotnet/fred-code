using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
  public class Pizza
  {
    // STATE
    //fields
    private string _imageUrl = "";
    private double _diameter = 0;
    private List<string> _toppings = new List<string>();

    //properties
    public string Crust { get; }
    public string Size { get; }
    public List<string> Toppings
    {
      get
      {
        return _toppings;
      }
    }


    // BEHAVIOR
    //constructors
    public Pizza(string size, string crust, List<string> toppings)
    {
      Size = size;
      Crust = crust;
      Toppings.AddRange(toppings);
    }

    //methods
    void AddToppings(string topping)
    {
      Toppings.Add(topping);
    }

    public override string ToString()
    {
      var sb = new StringBuilder();

      foreach(var t in Toppings)
      {
        sb.Append(t + ", ");
      }

      return $"{Crust} \n{Size} \n{sb}";
    }

    //finalizers or destructors
  }
}