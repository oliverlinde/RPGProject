using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GameLogic;
using GameLogic.Items.ConcreteItems;

namespace GameLogic.Items
{
    internal abstract class Consumable : Item
    {
        public ConsumableQuality ConsumableQuality { get; set; }

        private int _hitPointsToRestore;
        public int HitPointsToRestore
        {
            get => _hitPointsToRestore;
            set
            {
                _hitPointsToRestore = ConsumableQuality switch
                {
                    ConsumableQuality.Spoiled => (int)(value * 0.1),
                    ConsumableQuality.Bad => (int)(value * 0.5),
                    ConsumableQuality.Poor => (int)(value * 0.7),
                    ConsumableQuality.Fine => (int)(value * 1.3),
                    ConsumableQuality.Excellent => (int)(value * 1.5),
                    ConsumableQuality.Perfect => (int)(value * 2),
                    _ => value * 1,
                };
            }

        }

        protected Consumable(string title, int itemTypeId, ConsumableQuality consumableQuality, int hitPointsToRestore) : base(title, itemTypeId)
        {
            ConsumableQuality = consumableQuality;
            HitPointsToRestore = hitPointsToRestore;
        }

        public abstract void Consume(IHealable whoConsumesIt);

        public void RemoveWhenConsumed(IHealable player, Item item)
        {
            if (player is Player player1)
            {
                player1.Inventory.RemoveFromInventory(item);
            }
        }
    }
}


