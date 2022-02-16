using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic.Controllers
{
    public class PlayerController
    {
        public IPlayer Player { get; set; }

        public PlayerController()
        {
            Player = new Player("Player 1", 100);
        }

        public void AddToInventory(Item item)
        {
            Player.AddToInventory(item);
        }

        public void SetMainHand(Weapon weapon)
        {
            try
            {
                Player.MainHand = weapon;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void RemoveFromInventory(Item item)
        {
            Player.RemoveFromInventory(item);
        }

        public void Attack(IPlayer enemy)
        {
            Player.MainHand.Attack(enemy);
        }

        public void Consume(Consumable consumable)
        {
            consumable.Consume(Player);
        }
    }
}
