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
      Assert.AreEqual(true, (newOrder is Inventory));
    }

    [TestMethod]
    public void Inventory_ContainsPastryInventory_Float()
    {
      float expected = 1.50F;
      Assert.AreEqual(expected, Inventory.Pastry["croissant"]);
    }
  }
}
