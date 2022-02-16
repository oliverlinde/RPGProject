using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using GameLogic;
using GameLogic.Items;

namespace Game;

public class PlayerController
{
    public Player player;
    public PlayerController(string name)
    {
        player = new Player(name, 100);
    }

    public void AddToInventory(Item item)
    {
        player.AddToInventory(item);
    }

    public void SetMainHand(Weapon weapon)
    {
        if (player.Inventory.Items.Contains(weapon))
        {
            player.MainHand = weapon;
        }
        else
        {
            Console.WriteLine("Weapon is not in inventory!");
        }
    }

    public void Attack(Player enemy)
    {
        player.MainHand.Attack(enemy);
        Console.WriteLine("Attacking " + enemy.Name + ", dealing " + player.MainHand.Damage + " dmg. Enemy HP left: " + enemy.HitPoints);
    }

    public void Consume(Consumable consumable)
    {
        consumable.Consume(player);
        Console.WriteLine("Consumed " + consumable.Title + " HP is now " + player.HitPoints);
    }
}