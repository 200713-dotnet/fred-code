using System;

namespace HelloCsharp
{
  class Program
  {
    static void Main()
    {
      Console.Write("enter firstname: ");
      var firstName = Console.ReadLine(); //lazy, datatype is given based on content of Readline
      Console.Write("enter lastname: ");
      string lastName = Console.ReadLine(); //eager, datatype is explicit prior to content of Readline

      Console.WriteLine(firstName + " " + lastName);
      Console.WriteLine("{0} {1}", firstName, lastName);
      Console.WriteLine($"{firstName} {lastName}");

      Console.ReadLine();
    }
  }
}