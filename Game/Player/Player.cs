using Game.Items;
using Game.Enemies;

namespace Game.Character
{
    internal sealed class Player
    {
        private static Player _instance;
        private readonly int maxHp;
        private readonly int maxStamina;
        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Stamina { get; set; }
        public int Gold { get; set; }
        public Backpack Backpack { get; set; }
        public Sword Sword { get; set; }
        public Armor Armor { get; set; }

        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Player();
                }

                return _instance;
            }
        }

        private Player()
        {
            Name = "Jogador";
            Backpack = new Backpack(10);
            HP = 100;
            maxHp = 100;
            Stamina = 100;
            maxStamina = 100;
            maxHp = 100;
            Gold = 50;
            Sword = new WoodenSword();
            Armor = new LeatherSet();;
        }

        public void Sleep()
        {
            UpdateHP(HP + 30);
            UpdateStamina(Stamina + 30);
        }

        public void Attack(Enemy _enemy)
        {
            Random rnd = new Random();
            int extraDamage = rnd.Next(1, 30);

            if (Stamina < 20)
            {
                return;
            }

            _enemy.UpdateHP(-(Sword.Attack() + extraDamage));
            UpdateStamina(Stamina - 20);
        }

        public void UpdateStamina(int _stamina)
        {
            Stamina = _stamina;

            if (Stamina > 100)
            {
                Stamina = 100;
            }
            else if (Stamina < 0)
            {
                Stamina = 0;
            }
        }

        public void UpdateHP(int _hp)
        {
            int diff = HP - _hp;

            if (diff > 0 && Armor.Protection() - diff < 0)
            {
                HP += (Armor.Protection() - diff);
            }
            else
            {
                HP = _hp;
            }

            if (HP > 100)
            {
                HP = 100;
            }
        }
    }
}
