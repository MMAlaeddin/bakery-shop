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
      BreadPrice = 5 * breadAmount;   
    }
    public void TheBreadAmount(int breadAmount)
    {
    if (BreadAmount == 2 || BreadAmount == 3)
      {
      BreadPrice += 5;
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
      PastryPrice = 2 * pastryAmount;
    }
    public void ThePastryAmount(int pastryAmount)
    {
      if (PastryAmount == 3)
      {
        PastryPrice += 3;
      }
    }
  }
}