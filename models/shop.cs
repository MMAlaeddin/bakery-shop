using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Bread
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Bread(int amount, int price)
    {
      Amount = amount;
      Price = 5;   
    }
    public int BreadAmount(int amount, int price)
    {
    if (Amount == 2 || Amount == 3)
      {
      Price += 5;
      }
    }
  }
}