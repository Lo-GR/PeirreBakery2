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
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Big Mac Daniel's";
      Order newOrder = new Order(title, "testDescription", 1, 2, 3, 4);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "The biggest macaronis in town";
      string title = "Big Mac Daniel's";
      Order newOrder = new Order(title, description, 1, 2, 3, 4);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}