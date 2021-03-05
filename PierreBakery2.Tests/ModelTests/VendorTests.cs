  using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierrebakery2.Models;
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
      Vendor newVen = new Vendor()
      Assert.AreEqual(typeof(Vendor), newVen.GetType());
    }
  }
}
