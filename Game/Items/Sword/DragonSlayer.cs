using Game.Character;

namespace Game.Items
{
    internal class DragonSlayer : Sword
    {
        private const string name = "DragonSlayer";
        private const int price = 500;
        private const string description = "Espada lendária do matador de dragões";
        private const int attack = 220;

        public DragonSlayer()
            : base(name, price, description, attack)
        {

        }

        public override void Use()
        {
            Player.Instance.Sword = this;
        }
    }
}
