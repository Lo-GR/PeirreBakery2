using System;
using System.Collections.Generic;

namespace PierreBakery2.Models
{
  public class Vendor
  {
    public string Name {get;}
    public int Id {get;}
    public Vendor(string vendorName)
    {
      Name = vendorName;
      Id = 200;
    }
  }
}