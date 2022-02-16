using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        public void AddToInventory(Item item)
        {
            Items.Add(item);
        }

        public void RemoveFromInventory(Item item)
        {
            Items.Remove(item);
        }
    }
}
