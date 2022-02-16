namespace GameLogic.Items.ConcreteItems;

public class Food : Consumable
{

    public Food(int itemTypeId, string title, int value, ConsumableQuality consumableQuality, int hitPointsToRestore) : base(title, itemTypeId, value, consumableQuality, hitPointsToRestore)
    {
        
    }
    public override void Consume(IHealable whoConsumesIt)
    {
        whoConsumesIt.Heal(HitPointsToRestore);
        RemoveWhenConsumed(whoConsumesIt, this);
    }

    public override Item? Clone()
    {
        return new Food(ItemTypeID, Title, Value, ConsumableQuality, HitPointsToRestore);
    }

}