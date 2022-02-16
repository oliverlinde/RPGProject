using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic.Items;

internal abstract class Weapon : Item
{
    private int _damage;
    public WeaponCondition Condition { get; set; }
    public int Damage
    {
        get => _damage;
        set
        {
            _damage = Condition switch
            {
                WeaponCondition.Broken => (int)(value * 0.1),
                WeaponCondition.Bad => (int)(value * 0.5),
                WeaponCondition.Poor => (int)(value * 0.7),
                WeaponCondition.Fine => (int)(value * 1.3),
                WeaponCondition.Superior => (int)(value * 1.5),
                WeaponCondition.Flawless => (int)(value * 2),
                _ => value * 1,
            };
        }
    }

    protected Weapon(int itemTypeId, string title, WeaponCondition condition, int damage) 
        : base(title, itemTypeId)
    {
        Condition = condition;
        Damage = damage;
    }

    public abstract void Attack(IDamageable playerToAttack);

}