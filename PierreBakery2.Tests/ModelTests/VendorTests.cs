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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> {};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsPopulatedList_VendorList()
    {
      string name1 = "Big Mac Daniel's Macaronis";
      Vendor vendor1 = new Vendor(name1);
      string name2 = "Little Limes on Little Lane";
      Vendor vendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
