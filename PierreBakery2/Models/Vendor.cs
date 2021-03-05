using System;
using System.Collections.Generic;

namespace PierreBakery2.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name {get;}
    public int Id {get;}
    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = 200;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
  {
    _instances.Clear();
  }
  }
}