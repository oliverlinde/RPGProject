using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Factories;
using GameLogic.Items;

namespace GameLogic.Controllers
{
    public class WeaponController
    {

        public WeaponController()
        {
        }

        public Weapon CloneWeapon(int itemId)
        {
            Item item = ItemFactory.CreateItem(itemId);
            if (item is Weapon weapon)
            {
                DecideCondition(weapon);
                weapon.Damage = weapon.Damage;
                weapon.Value = weapon.Value;
                return weapon;
            }
            return null;
        }

        private void DecideCondition(Weapon weapon)
        {
            Random random = new Random();
            int ran = random.Next(1, 100);
            switch (ran)
            {
                case <= 5:
                    weapon.Condition = WeaponCondition.Broken;
                    break;
                case >= 5 and < 15:
                    weapon.Condition = WeaponCondition.Poor;
                    break;
                case >= 15 and < 35:
                    weapon.Condition = WeaponCondition.Bad;
                    break;
                case >= 35 and < 65:
                    weapon.Condition = WeaponCondition.Good;
                    break;
                case >= 65 and < 85:
                    weapon.Condition = WeaponCondition.Fine;
                    break;
                case >= 85 and < 95:
                    weapon.Condition = WeaponCondition.Superior;
                    break;
                case >= 95:
                    weapon.Condition = WeaponCondition.Flawless;
                    break;
            }
        }
    }
}
