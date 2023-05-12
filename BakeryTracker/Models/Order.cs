using System;
using System.Collections.Generic;
using System.Globalization;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Amount { get; set; }
    public float Total { get; set; }
    public float Price { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public static List<Order> Orders { get; set; } = new List<Order>();
    public int Id { get; }

    public Order(string item, int amount)
    {
      float price;
      if (Inventory.Pastry.TryGetValue(item, out price) )
      {
        Title = item;
        Amount = amount;
        Total = amount * price;
        Price = price;
        Date = DateTime.Now;
        Type = "pastry";
        Orders.Add(this);
        Id = Orders.Count;
      }
      else if (Inventory.Bread.TryGetValue(item, out price))
      {
        Title = item;
        Amount = amount;
        Total = amount * price;
        Price = price;
        Date = DateTime.Now;
        Type = "bread";
        Orders.Add(this);
        Id = Orders.Count;
      }
    }

    public static void ClearAll()
    {
      Orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return Orders[searchId-1];
    }
  }
}