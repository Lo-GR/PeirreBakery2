using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery2.Models;
using System;
using System.Collections.Generic;

namespace PierreBakery2.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string description = "The biggest macaronis in town";
      string title = "Big Mac Daniel's";
      int price = 5;
      Order newOrder = new Order(title, description, price, 2, 3, 4);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDateTimeInstance_Date()
    {
      string description = "The biggest macaronis in town";
      string title = "Big Mac Daniel's";
      int price = 5;
      Order newOrder = new Order(title, description, price, 2000, 3, 4);
      DateTime result = newOrder.Date;
      Assert.AreEqual(typeof(DateTime), result.GetType());
    }
    [TestMethod]
    public void ReturnDate_ReturnsDateTimeString_String()
    {
      string description = "The biggest macaronis in town";
      string title = "Big Mac Daniel's";
      int price = 5;
      Order newOrder = new Order(title, description, price, 2000, 3, 4);
      string expectedResult = "3/4/2000";
      Assert.AreEqual(newOrder.ReturnDate(), expectedResult);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsPopulatedList_OrderList()
    {
      Order order1 = new Order("Big Mac Daniel's", "The biggest macaronis in town", 5, 2000, 3, 4);
      Order order2 = new Order("Tiny Limes", "Tiniest Limes Around", 2, 2000, 3, 4);
      List<Order> newOrders = new List<Order> {order1, order2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrders, result);
    }
    [TestMethod]
    public void GetId_OrderGetsIdaAndGetterReturns_Int()
    {
      Order order1 = new Order("Big Mac Daniel's", "The biggest macaronis in town", 5, 2000, 3, 4);
      int result = order1.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order order1 = new Order("Big Mac Daniel's", "The biggest macaronis in town", 5, 2000, 3, 4);
      Order order2 = new Order("Tiny Limes", "Tiniest Limes Around", 2, 2000, 3, 4);
      Order result = Order.Find(2);
      Assert.AreEqual(order2, result);
    }
  }
}