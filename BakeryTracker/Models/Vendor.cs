using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; } = new List<Order> {};
    public static List<Vendor> AllVendors { get; set; } = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      AllVendors.Add(this);
      Id = AllVendors.Count;
    }

    public static void ClearAll()
    {
      AllVendors.Clear();
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static Vendor Find(int searchId)
    {
      return AllVendors[searchId-1];
    }
  }
}