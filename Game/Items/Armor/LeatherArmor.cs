namespace Game.Items
{
    internal class LeatherSet : Armor
    {
        private const string name = "Traje de couro";
        private const int price = 1000;
        private const string description = "Traje de couro com baixa defesa";
        private const int protection = 20;

        public LeatherSet()
            : base(name, price, description, protection)
        {

        }
    }
}
