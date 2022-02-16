using System;
using GameLogic.Controllers;
using GameLogic.Items;
using Xunit;

namespace GameLogicTest
{
    public class CreateWeaponTest
    {
        
        [Fact]
        public void ReturnOnlyTypeWeapon()
        {
            // Arrange
            WeaponController weaponController = new WeaponController();
            
            // Act
            Item item1 = weaponController.CloneWeapon(1001);
            Item item2 = weaponController.CloneWeapon(101);

            // Assert
            Assert.True(item1 is Weapon);
            Assert.True(item2 is not Weapon);
        }
    }
}