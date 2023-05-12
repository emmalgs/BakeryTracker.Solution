using System;
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
      }
      else if (Inventory.Bread.TryGetValue(item, out price))
      {
        Title = item;
        Amount = amount;
        Total = amount * price;
        Price = price;
        Date = DateTime.Now;
        Type = "bread";
      }
    }
  }
}