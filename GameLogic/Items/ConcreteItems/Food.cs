namespace GameLogic.Items.ConcreteItems;

internal class Food : Consumable
{

    public Food(int itemTypeId, string title, ConsumableQuality consumableQuality, int hitPointsToRestore) : base(title, itemTypeId, consumableQuality, hitPointsToRestore)
    {
        
    }
    public override void Consume(IHealable whoConsumesIt)
    {
        whoConsumesIt.Heal(HitPointsToRestore);
        RemoveWhenConsumed(whoConsumesIt, this);
    }

    public override Item? Clone()
    {
        return new Food(ItemTypeID, Title, ConsumableQuality, HitPointsToRestore);
    }
}