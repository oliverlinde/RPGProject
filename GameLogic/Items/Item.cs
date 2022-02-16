namespace GameLogic.Items
{
    internal abstract class Item : IPickUp
    {
        public int ItemTypeID { get; set; }
        public string Title { get; set; }

        protected Item(string title, int itemTypeId)
        {
            ItemTypeID = itemTypeId;
            Title = title;
        }

        public abstract Item? Clone();

        public void PickUp(Item item)
        {
            throw new NotImplementedException();
        }

        public void DropItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}