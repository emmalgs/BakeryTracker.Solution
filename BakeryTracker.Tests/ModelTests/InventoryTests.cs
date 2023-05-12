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
      Order newOrder = new Order("croissant", 5);
      Assert.AreEqual(true, (newOrder is Inventory));
    }

    [TestMethod]
    public void Inventory_ContainsPastryInventory_Float()
    {
      float expected = 1.50F;
      Assert.AreEqual(expected, Inventory.Pastry["croissant"]);
    }

    [TestMethod]
    public void Inventory_ContainsBreadInventory_Float()
    {
      float expected = 5.55F;
      Assert.AreEqual(expected, Inventory.Bread["squirrel swirl"]);
    }
  }
}
