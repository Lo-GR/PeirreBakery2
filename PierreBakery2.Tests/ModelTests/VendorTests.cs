  using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery2.Models;
using System.Collections.Generic;
using System;

namespace PierreBakery2.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVen = new Vendor("Big Mac Daniel's Macaronis");
      Assert.AreEqual(typeof(Vendor), newVen.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Big Mac Daniel's Macaronis";
      Vendor newVen = new Vendor(name);
      string result = newVen.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void Getid_ReturnsVendorId_Int()
    {
      string name = "Big Mac Daniel's Macaronis";
      Vendor newVen = new Vendor(name);
      int result = newVen.Id;
      Assert.AreEqual(1, result);
    }
  }
}
