using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderClass_CreatesInstanceOfTypeOrder_Order()
    {
      Order newOrder = new Order("croissant", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void Order_CreatesInstanceOfOrderWithInfo_Order()
    {
      Order newOrder = new Order("croissant", 5);
      float expected = 7.50F;
      Assert.AreEqual(expected, newOrder.Total);
    }

    [TestMethod]
    public void Order_HasTitleInfo_String()
    {
      Order newOrder = new Order("croissant", 5);
      string expected = "croissant";
      Assert.AreEqual(expected, newOrder.Title);
    }

    [TestMethod]
    public void Order_HasAmount_Int()
    {
      Order newOrder = new Order("croissant", 5);
      int expected = 5;
      Assert.AreEqual(expected, newOrder.Amount);
    }

    [TestMethod]
    public void Order_HasPrice_Float()
    {
      Order newOrder = new Order("croissant", 5);
      float expected = 1.50F;
      Assert.AreEqual(expected, newOrder.Price);
    }

    [TestMethod]
    public void Order_HasDate_String()
    {
      Order newOrder = new Order("croissant", 5);
      string expected = "2023-05-12";
      Assert.AreEqual(expected, newOrder.Date.ToString("yyyy-MM-dd"));
    }

    [TestMethod]
    public void Order_HasType_String()
    {
      Order newOrder = new Order("croissant", 5);
      string expected = "pastry";
      Assert.AreEqual(expected, newOrder.Type);
    }

    [TestMethod]
    public void Order_HasListOfOrders_Int()
    {
      Order croissant = new Order("croissant", 5);
      Order pirates = new Order("pirates booty", 6);
      Order flapjack = new Order("flapjack bingo", 3);
      Order coco = new Order("coco nono", 3);
      int expected = 4;
      Assert.AreEqual(expected, Order.Orders.Count);
    }

    [TestMethod]
    public void Order_OrderHasId_Int()
    {
      Order croissant = new Order("croissant", 5);
      Order pirates = new Order("pirates booty", 6);
      Order flapjack = new Order("flapjack bingo", 3);
      Order coco = new Order("coco nono", 3);
      int expected = 4;
      Assert.AreEqual(expected, coco.Id);
    }
  }
}