using System;
using System.Collections.Generic;
using Shop.Models;

namespace Shop
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Bakery! Would you like some bread, a pastry or both?");
      string userResponse = Console.ReadLine().ToLower();
    }
  }
}