namespace BakeryTracker.Models
{
  public class Order : Inventory
  {
    public float Total { get; set; }
    public Order(string item, int amount)
    {
      float price;
      if (Pastry.TryGetValue(item, out price) || Bread.TryGetValue(item, out price))
      {
        Total = amount * price;
      }
    }
  }
}