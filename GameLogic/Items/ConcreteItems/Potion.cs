namespace GameLogic.Items.ConcreteItems;

internal class Potion : Consumable
{

    public Potion(int itemTypeId, string title, ConsumableQuality consumableQuality, int hitPointsToRestore) : base(title, itemTypeId, consumableQuality, hitPointsToRestore)
    {
    }

    public override Item? Clone()
    {
        throw new NotImplementedException();
    }

    public override void Consume(IHealable whoConsumesIt)
    {
        whoConsumesIt.Heal(HitPointsToRestore);
        RemoveWhenConsumed(whoConsumesIt, this);
    }
}