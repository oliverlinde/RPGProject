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

        private int _hitPoints;
        private int _gold;
        private int _experiencePoints;
        private int _level;
        private string _name;

        public int HitPoints
        {
            get { return _hitPoints;}
            set { _hitPoints = value; }

        }

        public int Gold
        {
            get { return _gold;}
            set { _gold = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints;}
            set { _experiencePoints = value; }

        }

        public int Level
        {
            get { return _level;}
            set { _level = value; }

        }

        private bool _isAlive = true;

        public bool IsAlive
        {
            get { return _isAlive;}
            set { _isAlive = value; }
        }
        public string Name
        {
            get { return _name;}
            set { _name = value; }

        }
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
