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
      Price = price;   
    }
    public int GetAmount(int amount)
    {
      if (amount == 1)
      {
        return 5;
      }
        else if (amount == 2 || amount == 3)
          {
            return 10;
          }
        }
      }
    }