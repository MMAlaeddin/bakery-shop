using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Collections.Generic;
using Shop.Models;

namespace Shop
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Bakery! Would you like to order [bread] or [pastries]?", Color.Pink);
      string userResponse = Console.ReadLine().ToLower();

      if (userResponse.Contains("bread"))
      {
        Console.WriteLine("How much bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread myBread = new Bread(breadOrder);
        myBread.TheBreadAmount(breadOrder);
        Console.WriteLine("Your total cost is " + "$" + myBread.BreadPrice);
        Console.WriteLine("Thank your for your business!");
      }
      else if (userResponse.Contains("pastries"))
      {
        Console.WriteLine("How many pastries would you like?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry myPastry = new Pastry(pastryOrder);
        myPastry.ThePastryAmount(pastryOrder);
        Console.WriteLine("Your total cost is " + "$" + myPastry.PastryPrice);
        Console.WriteLine("Thank your for your business!");
      }
      else if(userResponse != "bread" || userResponse != "pastries")
      {
      Console.WriteLine("Get out of here!");
      }
    }
  }
}