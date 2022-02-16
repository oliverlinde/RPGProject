using GameLogic.Items;

namespace GameLogic;

internal interface IPlayer : IDamageable, IHealable
{
    public string Name { get; set; }
    public bool IsAlive { get; set; }
    public int HitPoints { get; set; }
    public void Die();
    public void Respawn();
    public void AddToInventory(Item item);
    public void RemoveFromInventory(Item item);
}