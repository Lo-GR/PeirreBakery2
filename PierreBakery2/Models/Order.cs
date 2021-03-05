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
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};
    public Order(string title, string description, int price, int year, int month, int day)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = new DateTime(year, month, day);
      _instances.Add(this);
      Id = _instances.Count;
    }
    public string ReturnDate()
    {
      string stringDate = Date.ToString("d");
      return stringDate;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return null;
    }
  }
}