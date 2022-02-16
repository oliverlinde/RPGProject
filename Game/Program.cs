
using System.Threading.Channels;
using Game;
using GameLogic;
using GameLogic.Controllers;
using GameLogic.Items;
using GameLogic.Items.ConcreteItems;

//Player player = new Player(50);
//Player player2 = new Player(50);


//player2.AddToInventory(axe);
//player2.AddToInventory(food);

//player.AddToInventory(food);
//player.AddToInventory(sword);



//sword.Attack(player);
//Console.WriteLine("Attacking player with a " + sword.Title + " inflicting " + sword.Damage + " dmg. New HP: " + player.HitPoints);
//axe.Attack(player);
//Console.WriteLine("Attacking player with a " + axe.Title + " inflicting " + axe.Damage + " dmg. New HP: " + player.HitPoints);

//potion.Consume(player);
//food.Consume(player);
//Console.WriteLine("Eating a " + food.Title + " for " + food.HitPointsToRestore + " HP. New HP: " + player.HitPoints);

//foreach (var item in player.Inventory.Items)
//{
//    Console.WriteLine(item.Title);
//}


WeaponController weaponController = new WeaponController();

Weapon w1 = weaponController.CloneWeapon(1001);
Weapon w2 = weaponController.CloneWeapon(1001);

Console.WriteLine("Weapon 1: " + w1.Damage + ", " + w1.Condition.ToString() + ", " + w1.Value);
Console.WriteLine("Weapon 2: " + w2.Damage + ", " + w2.Condition.ToString() + ", " + w2.Value);