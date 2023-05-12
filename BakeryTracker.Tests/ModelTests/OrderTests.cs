using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

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
  }
}