namespace GameLogic.Items.ConcreteItems;

public class Sword : Weapon
{
    public Sword(int itemTypeId, string title, int value, int damage, WeaponCondition condition) 
        : base(itemTypeId, title, value, condition, damage)
    {
        
    }

    public override void Attack(IDamageable playerToAttack)
    {
        playerToAttack.TakeDamage(Damage);
    }

    public override Item? Clone()
    {
        return new Sword(ItemTypeID, Title, Value, Damage, Condition);
    }
}