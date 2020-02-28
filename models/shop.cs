using System;
using System.Collections.Generic;

namespace Shop.Models
{
    public class Bread
  {
    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }

    public Bread(int breadAmount, int breadPrice)
    {
      BreadAmount = breadAmount;
      BreadPrice = 5;   
    }
    public void TheBreadAmount(int breadAmount, int breadPrice)
    {
    if (BreadAmount == 2 || BreadAmount == 3)
      {
      BreadPrice += 10;
      }
    }
  }
  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryAmount, int pastryPrice)
    {
      PastryAmount = pastryAmount;
      PastryPrice = 2;
    }
    public void ThePastryAmount(int pastryAmount, int pastryPrice)
    {
      if (PastryAmount == 3)
      {
        PastryPrice += 3;
      }
    }
  }
}