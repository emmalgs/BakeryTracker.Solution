using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class InventoryTests
  {

    [TestMethod]
    public void Inventory_InstanceOfOrderInheritsTypeInventory_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Inventory), newOrder.GetType());
    }
  }
}
