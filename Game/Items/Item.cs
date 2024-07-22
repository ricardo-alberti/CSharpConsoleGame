namespace Game.Items
{
    internal abstract class Item
    {
        private readonly string name;
        private readonly int price;
        private readonly string description;

        public Item(string _name, int _price, string _description)
        {
            name = _name;
            price = _price;
            description = _description;
        }

        public string Name()
        {
            return name;
        }

        public int Price()
        {
            return price;
        }   

        public string Description()
        {
            return description;
        }

        public abstract void Use();
    }
}
