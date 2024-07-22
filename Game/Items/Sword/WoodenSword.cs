using Game.Character;

namespace Game.Items
{
    internal class WoodenSword : Sword
    {
        private const string name = "Espada de madeira";
        private const int price = 50;
        private const string description = "Espada de madeira simples";
        private const int attack = 20;

        public WoodenSword()
            : base(name, price, description, attack)
        {

        }

        public override void Use()
        {
            Player.Instance.Sword = this;
        }
    }
}
