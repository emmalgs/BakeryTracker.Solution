using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> AllVendors { get; set; } = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      AllVendors.Add(this);
    }

    public static void ClearAll()
    {
      AllVendors.Clear();
    }
  }
}