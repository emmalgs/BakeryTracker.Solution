using System;
using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Inventory
  {
    public static Dictionary<string, float> Pastry { get; } = new Dictionary<string, float>
    {
      {"croissant", 1.50F},
      {"danish", 1.25F},
      {"pumpkin maniac", 2.75F},
      {"squirrel", 2.50F},
      {"coco nono", 1.50F},
      {"scrambled egg donut", 2.35F}
    };
    public static Dictionary<string, float> Bread { get; } = new Dictionary<string, float>
    {
      {"sourdough", 4.00F},
      {"pirates booty", 4.50F},
      {"scooter roll", 3.00F},
      {"flapjack bingo", 3.50F},
      {"saucy queso gord", 4.50F},
      {"squirrel swirl", 5.55F},
      {"rye", 3.50F}
    };
  }
}