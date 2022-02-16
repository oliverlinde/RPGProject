using GameLogic.Items;

namespace GameLogic;

public interface IPlayer : IDamageable, IHealable
{
    public string Name { get; set; }
    public bool IsAlive { get; set; }
    public int HitPoints { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public Weapon MainHand { get; set; }
    public Item OffHand { get; set; }
    public Inventory Inventory { get; set; }
    public void Die();
    public void Respawn();
    public void AddToInventory(Item item);
    public void RemoveFromInventory(Item item);
}