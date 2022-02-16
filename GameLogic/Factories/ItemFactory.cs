using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;
using GameLogic.Items.ConcreteItems;

namespace GameLogic.Factories
{
    public static class ItemFactory
    {
        private static List<Item> _standardItems;

        static ItemFactory()
        {
            _standardItems = new List<Item>();

            // Weapons
            _standardItems.Add(new Sword(1001, "Steel Sword", 10, WeaponCondition.Good));
            _standardItems.Add(new Axe(2001, "Steel Axe", 10, WeaponCondition.Good));
            _standardItems.Add(new Axe(2002, "Obsidian Axe", 50, WeaponCondition.Good));

            // Food
            _standardItems.Add(new Food(101, "Wheat Bread", ConsumableQuality.Good, 5));
            _standardItems.Add(new Food(102, "Beef Jerky", ConsumableQuality.Good, 15));

            // Potions
            _standardItems.Add(new Potion(201, "Healing Potion", ConsumableQuality.Good, 30));
            _standardItems.Add(new Potion(202, "Orange Juice", ConsumableQuality.Good, 10));
        }

        public static Item? CreateItem(int itemTypeId)
        {
            var standardItem = _standardItems.FirstOrDefault(item => item.ItemTypeID == itemTypeId);

            return standardItem?.Clone();
        }
    }
}
