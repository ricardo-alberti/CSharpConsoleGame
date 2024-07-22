namespace Game.Items
{
    internal class Backpack : Item
    {
        private const string name = "Mochila";
        private const string description = "Aumenta a capacidade de itens";
        private const int price = 50;
        private readonly Dictionary<string, Item> items;
        private readonly int maxCapacity;
        private int UsedCapacity { get; set; }

        public Backpack(int _maxCapacity)
            : base(name, price, description)
        {
            items = new Dictionary<string, Item>();
            maxCapacity = _maxCapacity;
            UsedCapacity = 0;
        }

        public Dictionary<string, Item> Items()
        {
            return items;
        }

        public bool Contains(string _itemName)
        {
            return items.ContainsKey(_itemName);
        }

        public void AddItem(Item _item)
        {
            if (UsedCapacity < maxCapacity)
            {
                items.Add(_item.Name(), _item); 
                UsedCapacity++;
            }
        }

        public void RemoveItem(string _itemName)
        {
            if (items.ContainsKey(_itemName))
            {
                items.Remove(_itemName);
                UsedCapacity--;
            }
        }

        public override void Use()
        {

        }
    }
}
