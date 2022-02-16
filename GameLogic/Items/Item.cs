namespace GameLogic.Items
{
    public abstract class Item : IPickUp
    {
        public int ItemTypeID { get; set; }
        public int Value { get; set; }
        public string Title { get; set; }

        protected Item(string title, int itemTypeId, int value)
        {
            ItemTypeID = itemTypeId;
            Title = title;
            Value = value;
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

        public override string ToString()
        {
            return Title;
        }

        public virtual string printInfo()
        {
            return Title;
        }
    }
}