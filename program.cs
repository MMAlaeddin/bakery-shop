using System;
using System.Collections.Generic;
using Shop.Models;

namespace Shop
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Bakery! Would you like to order [bread] or [pastries]?");
      string userResponse = Console.ReadLine().ToLower();
      if (userResponse.Contains("bread"))
      {
        Console.WriteLine("How much bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
      }
    }
  }
}