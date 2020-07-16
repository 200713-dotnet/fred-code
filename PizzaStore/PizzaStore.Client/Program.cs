using System;
using System.Collections.Generic;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld");
      System.Console.WriteLine("Best Pizza in the World");
      System.Console.WriteLine();

      // array
      //1-dimensional
      string[] cart1 = { "", "", "" }; // initial values
      string[] cart2 = new string[3]; // default values
      string[] cart3 = new[] { "", "", "" }; // initial values - custom datatypes or earlier C# versions

      // list
      List<string> cart4 = new List<string>{"", "", ""}; // initial values
      List<string> cart5 = new List<string>(); // default values

      //Menu(cart2);
      Menu2(cart5);
    }

    static void Menu(string[] cart)
    {
      var exit = false;
      var number = 0;

      do
      {
        if (number < cart.Length)
        {
          System.Console.WriteLine("Select 1 for Cheese Pizza");
          System.Console.WriteLine("Select 2 for Pepperoni Pizza");
          System.Console.WriteLine("Select 3 for Pineapple Pizza");
          System.Console.WriteLine("Select 4 for Custom Pizza");
          System.Console.WriteLine("Select 5 for Show Cart");
          System.Console.WriteLine("Select 6 for Exit");
          System.Console.WriteLine();

          int select;

          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart[number] = "cheese";
              number += 1;
              System.Console.WriteLine("added Cheese");
              break;
            case 2:
              cart[number] = "pepperoni";
              number += 1;
              System.Console.WriteLine("added Pepperoni");
              break;
            case 3:
              cart[number] = "pineapple";
              number += 1;
              System.Console.WriteLine("added Pineapple");
              break;
            case 4:
              cart[number] = "custom";
              number += 1;
              System.Console.WriteLine("added Custom");
              break;
            case 5:
              DisplayCart(cart);
              break;
            case 6:
              System.Console.WriteLine("thank you, goodbye!");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart(cart);
          exit = true;
        }
      } while (!exit);
    }

    static void Menu2(List<string> cart)
    {
      var exit = false;
      var number = 0;

      do
      {
        if (number < 10)
        {
          System.Console.WriteLine("Select 1 for Cheese Pizza");
          System.Console.WriteLine("Select 2 for Pepperoni Pizza");
          System.Console.WriteLine("Select 3 for Pineapple Pizza");
          System.Console.WriteLine("Select 4 for Custom Pizza");
          System.Console.WriteLine("Select 5 for Show Cart");
          System.Console.WriteLine("Select 6 for Exit");
          System.Console.WriteLine();

          int select;

          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart.Add("cheese");
              number += 1;
              System.Console.WriteLine("added Cheese");
              break;
            case 2:
              cart.Add("pepperoni");
              number += 1;
              System.Console.WriteLine("added Pepperoni");
              break;
            case 3:
              cart[number] = "pineapple";
              number += 1;
              System.Console.WriteLine("added Pineapple");
              break;
            case 4:
              cart[number] = "custom";
              number += 1;
              System.Console.WriteLine("added Custom");
              break;
            case 5:
              DisplayCart2(cart);
              break;
            case 6:
              System.Console.WriteLine("thank you, goodbye!");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart2(cart);
          exit = true;
        }
      } while (!exit);
    }

    static void DisplayCart(string[] cart)
    {
      foreach(var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }

      // for(var i=0; i < cart.Length - 1; i += 1)
      // {
      //   System.Console.WriteLine(cart[i]);
      // }
    }

    static void DisplayCart2(List<string> cart)
    {
      foreach(var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }

      // for(var i=0; i < cart.Length - 1; i += 1)
      // {
      //   System.Console.WriteLine(cart[i]);
      // }
    }
  }
}
