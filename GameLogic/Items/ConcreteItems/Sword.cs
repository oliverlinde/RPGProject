namespace GameLogic.Items.ConcreteItems;

public class Sword : Weapon
{
    public Sword(int itemTypeId, string title, int damage, WeaponCondition condition) 
        : base(itemTypeId, title, condition, damage)
    {
        
    }

    public override void Attack(IDamageable playerToAttack)
    {
        playerToAttack.TakeDamage(Damage);
    }

    public override Item? Clone()
    {
        return new Sword(ItemTypeID, Title, Damage, Condition);
    }
}