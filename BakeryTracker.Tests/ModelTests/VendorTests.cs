using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System;
using System.Collections.Generic;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorClass_CreatesTypeVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Greg", "Some guy that asked to order wholesale");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Vendor_AddsNameToVendor_String()
    {
      Vendor newVendor = new Vendor("Victors JavaHut", "Rundown coffeeshop by motel");
      string expected = "Victors JavaHut";
      Assert.AreEqual(expected, newVendor.Name);
    }

    [TestMethod]
    public void Vendor_AddsDescriptionToVendor_String()
    {
      Vendor newVendor = new Vendor("Victors JavaHut", "Rundown coffeeshop by motel");
      string expected = "Rundown coffeeshop by motel";
      Assert.AreEqual(expected, newVendor.Description);
    }
  }
}