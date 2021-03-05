using System;
using System.Collections.Generic;

namespace PierreBakery2.Models
{
  public class Order
  {
    public string Title {get; }

    public Order(string title, string description, int price, int year, int month, int day)
    {
      Title = "test";
    }
  }
}