using System;
using System.Collections.Generic;

namespace Shop.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }
    public int BreadPrice { get; set; }

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;  
    }
    public int TheBreadAmount()
    {
      int BreadPrice = (BreadAmount - (BreadAmount / 3)) * 5;
      {
        return BreadPrice;
      }
    }
  }
  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
    public int ThePastryAmount()
    {
      PastryPrice = (PastryAmount - (PastryAmount / 3)) * 5;
      {
        return PastryPrice;
      }
    }
  }
}