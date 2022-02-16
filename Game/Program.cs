
using System.Threading.Channels;
using Game;
using GameLogic;
using GameLogic.Items;
using GameLogic.Items.ConcreteItems;

//Player player = new Player(50);
//Player player2 = new Player(50);

Potion potion = new Potion("Apple juice", 2);
Food food = new Food("Wheat bread", 5);
Sword sword = new Sword("Normal Steel Sword", 10, WeaponCondition.Good);
Axe axe = new Axe("A superior branch", 10, WeaponCondition.Superior);

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

PlayerController p1 = new PlayerController("Lars");
PlayerController p2 = new PlayerController("Henning");
p1.AddToInventory(sword);
p1.AddToInventory(food);
p1.SetMainHand(sword);
p2.AddToInventory(axe);
p2.AddToInventory(food);
p2.SetMainHand(axe);

p1.Attack(p2.player);
p2.Attack(p1.player);