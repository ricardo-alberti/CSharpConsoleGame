using Game.Character;

namespace Game.Items
{
    internal class Potion : Item
    {
        private const string name = "Poção";
        private const string description = "Cura pontos de vida";
        private const int price = 50;
        private readonly int regenerationPoints;

        public Potion(int _regenerationPoints)
            : base(name, price, description)
        {
            regenerationPoints = _regenerationPoints;
        }

        public override void Use()
        {
            Player.Instance.UpdateHP(Player.Instance.HP + regenerationPoints);
            Player.Instance.Backpack.RemoveItem(name);
        }
    }
}
