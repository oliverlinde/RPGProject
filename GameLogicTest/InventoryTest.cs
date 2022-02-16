using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic;
using GameLogic.Controllers;
using GameLogic.Items;
using Xunit;

namespace GameLogicTest
{
    public class InventoryTest
    {

        [Fact]
        public void SetMainHandWithoutItemInInventory()
        {
            // Arrange
            Player player1 = new Player("Test", 100);
            PlayerController playerController = new PlayerController();
            WeaponController weaponController = new WeaponController();

            // Act
            playerController.SetMainHand(weaponController.CloneWeapon(1001));

            // Assert
            Assert.False(player1.MainHand is null);
        }

        [Fact]
        public void SetMainHandWithItemInInventory()
        {
            // Arrange
            Player player1 = new Player("Test", 100);
            PlayerController playerController = new PlayerController();
            WeaponController weaponController = new WeaponController();

            // Act
            playerController.AddToInventory(weaponController.CloneWeapon(1001));
            playerController.SetMainHand((Weapon)player1.Inventory.Items.First());

            // Assert
            Assert.True(player1.MainHand is not null);
        }

        [Fact]
        public void WeaponDamageShouldBeDifferent()
        {
            //Arrange

            WeaponController weaponController = new WeaponController();
            
            // Act

            Weapon w1 = weaponController.CloneWeapon(1001);
            Weapon w2 = weaponController.CloneWeapon(1001);

            // Assert
            Assert.NotEqual(w1.Damage, w2.Damage);
        }
    }
}
