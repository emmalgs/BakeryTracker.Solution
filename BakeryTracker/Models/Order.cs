namespace BakeryTracker.Models
{
  public class Order
  {
    public float Total { get; set; }
    public Order(string item, int amount)
    {
      float price;
      if (Inventory.Pastry.TryGetValue(item, out price) || Inventory.Bread.TryGetValue(item, out price))
      {
        Total = amount * price;
      }
    }
  }
}