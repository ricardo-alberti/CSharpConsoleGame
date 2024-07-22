namespace Game.Items
{
    internal class KnightArmor : Armor
    {
        private const int id = 5;
        private const string name = "Armadura de caveleiro";
        private const int price = 3000;
        private const string description = "Armadura de cavaleiro com alta defesa";
        private const int protection = 150;

        public KnightArmor()
            : base(name, price, description, protection)
        {

        }
    }
}
