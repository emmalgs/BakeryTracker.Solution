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
      Vendor newVendor = new Vendor("Greg");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Vendor_AddsNameToVendor_String()
    {
      Vendor newVendor = new Vendor("Victors JavaHut");
      string expected = "Victors JavaHut";
      Assert.AreEqual(expected, newVendor.Name);
    }
  }
}