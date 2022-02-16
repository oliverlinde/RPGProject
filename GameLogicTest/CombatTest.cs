using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GameLogic;
using GameLogic.Controllers;
using GameLogic.Factories;
using GameLogic.Items;
using GameLogic.Items.ConcreteItems;
using Xunit;

namespace GameLogicTest
{
    public class CombatTest
    {
        [Fact]
        public void AttackPlayer()
        {
            // Arrange
            WeaponController weaponController = new WeaponController();

            Player player1 = new Player("Protagonist", 100);
            Player player2 = new Player("Antagonist", 100);

            PlayerController playerController = new PlayerController();
            playerController.AddToInventory(weaponController.CloneWeapon(1001));
            playerController.SetMainHand((Weapon)player1.Inventory.Items.First());

            // Act
            playerController.Attack(player2);

            // Assert
            Assert.NotEqual(100, player2.HitPoints);
        }

        [Fact]
        public void RemoveFoodFromInventory()
        {
            // Arrange
            Player player1 = new Player("Main", 100);
            PlayerController playerController = new PlayerController();
            Food food = (Food) ItemFactory.CreateItem(101);
            playerController.AddToInventory(food);

            // Act
            playerController.Consume(food);

            // Assert
            Assert.NotEqual(100, player1.HitPoints);
            Assert.False(player1.Inventory.Items.Any());

        }
    }
}
