using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Items;

namespace GameLogic.Items;

public abstract class Weapon : Item
{
    private int _damage;
    private int _value;

    public WeaponCondition Condition { get; set; }
    public int Damage
    {
        get => _damage;
        set => _damage = (int)(value * GetConditionValue());
    }

    public new int Value
    {
        get => _value;
        set => _value = (int)(value * GetConditionValue());
        
    }

    protected Weapon(int itemTypeId, string title, int value, WeaponCondition condition, int damage) 
        : base(title, itemTypeId, value)
    {
        Condition = condition;
        Damage = damage;
        Value = value;
    }

    private double GetConditionValue()
    {
        return this.Condition switch
        {
            WeaponCondition.Broken => 0.1,
            WeaponCondition.Bad => 0.5,
            WeaponCondition.Poor => 0.7,
            WeaponCondition.Fine => 1.3,
            WeaponCondition.Superior => 1.5,
            WeaponCondition.Flawless => 2,
            _ => 1
        };
    }

    public abstract void Attack(IDamageable playerToAttack);

    public override string printInfo()
    {
        return "Weapon: " + Title + Environment.NewLine + "Damage: " + Damage + Environment.NewLine + "Condition: " + Condition;
    }
}