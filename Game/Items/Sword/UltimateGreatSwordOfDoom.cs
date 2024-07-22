using Game.Character;

namespace Game.Items
{
    internal class UltimateGreatSwordOfDoom : Sword
    {
        private const string name = "Espada Of Doom";
        private const int price = 5000;
        private const string description = "Ultra grande espada of Doom";
        private const int attack = 9999;

        public UltimateGreatSwordOfDoom()
            : base(name, price, description, attack)
        {

        }

        public override void Use()
        {
            Player.Instance.Sword = this;
        }
    }
}
