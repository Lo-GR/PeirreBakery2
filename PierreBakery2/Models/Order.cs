using System;
using System.Collections.Generic;

namespace PierreBakery2.Models
{
  public class Order
  {
    public string Title {get; }
    public string Description {get; }
    public int Price {get;}
    public DateTime Date {get;}

    public Order(string title, string description, int price, int year, int month, int day)
    {
      Title = title;
      Description = description;
      Price = price;
    }
    public string ReturnDate()
    {
      return "test";
    }
  }
}