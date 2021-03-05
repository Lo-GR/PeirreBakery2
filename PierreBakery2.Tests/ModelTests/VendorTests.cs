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
      Assert.AreEqual(typeof(Order), newVen.GetType());
    }
  }
}
