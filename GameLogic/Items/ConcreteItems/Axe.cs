namespace GameLogic.Items.ConcreteItems;

internal class Axe : Weapon
{
    public Axe(int itemTypeId, string title, int damage, WeaponCondition condition) 
        : base(itemTypeId, title, condition, damage)
    {
    }

    public override void Attack(IDamageable playerToAttack)
    {
        playerToAttack.TakeDamage(Damage);
    }

    public override Item? Clone()
    {
        return new Axe(ItemTypeID, Title, Damage, Condition);
    }
}