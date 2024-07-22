using Game.Character;

namespace Game.Items
{
    abstract class Armor : Item
    {
        private readonly int protection;

        public Armor(string _name, int _price, string _description, int _protection)
            : base(_name, _price, _description)
        {
            protection = _protection;
        }

        public int Protection()
        {
            return protection;
        }

        public override void Use()
        {
            Player.Instance.Armor = this;
        }
    }
}
