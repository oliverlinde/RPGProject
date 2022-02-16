namespace GameLogic.Items.ConcreteItems;

public class Axe : Weapon
{
    public Axe(int itemTypeId, string title, int value, int damage, WeaponCondition condition) 
        : base(itemTypeId, title, value, condition, damage)
    {
    }

    public override void Attack(IDamageable playerToAttack)
    {
        playerToAttack.TakeDamage(Damage);
    }

    public override Item? Clone()
    {
        return new Axe(ItemTypeID, Title, Value, Damage, Condition);
    }
}