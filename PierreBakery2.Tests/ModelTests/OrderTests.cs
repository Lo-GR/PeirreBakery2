using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery2.Models;
using System;
using System.Collections.Generic;

namespace PierreBakery2.Tests
{
  [TestClass]
  public class OrderTests
  //IDisposable
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 1, 2, 3, 4); // ints are price, year, month, day
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}