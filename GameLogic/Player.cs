using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic
{
    public class Player : IPlayer
    {
        public int HitPoints { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public Weapon MainHand { get; set; }
        public Item OffHand { get; set; }
        public Inventory Inventory { get; set; }


        public Player(string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            IsAlive = true;
            Inventory = new Inventory();
        }

        public void Die()
        {

        }

        public void Heal(int amountToHeal)
        {
            HitPoints += amountToHeal;
        }

        public void Respawn()
        {

        }

        public void TakeDamage(int amountOfDamage)
        {
            HitPoints -= amountOfDamage;
        }

        public void AddToInventory(Item item)
        {
            Inventory.AddToInventory(item);
        }

        public void RemoveFromInventory(Item item)
        {
            Inventory.RemoveFromInventory(item);
        }
    }
}
