namespace Game.Items
{
    abstract class Sword : Item
    {
        private readonly int attack;

        public Sword(string _name, int _price, string _description, int _attack)
            : base(_name, _price, _description)
        {
            attack = _attack;
        }

        public int Attack()
        {
            return attack;
        }

    }
}
