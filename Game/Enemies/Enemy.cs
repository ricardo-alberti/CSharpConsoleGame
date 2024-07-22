using Game.Character;

namespace Game.Enemies
{
    internal abstract class Enemy
    {
        private readonly string name;
        private readonly int attack;
        private readonly int gold;
        private readonly int maxHp;
        private readonly int maxStamina;
        private readonly string[] body;
        public int Stamina { get; set; }
        public int HP { get; set; }

        public Enemy(string _name, int _maxHp, int _maxStamina, int _attack, string[] _body, int _gold)
        {
            name = _name;
            HP = _maxHp;
            maxHp = _maxHp;
            Stamina = _maxStamina;
            maxStamina = _maxStamina;
            attack = _attack;
            body = _body;
            gold = _gold;
        }

        public string Name()
        {
            return name;
        }

        public int Gold()
        {
            return gold;
        }

        public string[] Body()
        {
            return body;
        }

        public void PlayTurn()
        {
            if (Stamina < 10 || HP < maxHp / 4)
            {
                Sleep();
                return;
            }

            Attack();
        }

        public string HealthBar()
        {
            char healthBlock = '■';
            char takenHealth = '□';
            string healthBar = "";

            int i = 0;
            for (; i < HP; i += maxHp / 40)
            {
                healthBar += healthBlock;
            }

            int hpTaken = maxHp - i;
            for (int j = 0; j < hpTaken; j += maxHp / 40)
            {
                healthBar += takenHealth;
            }

            return $"[{healthBar}]";
        }

        public void UpdateHP(int _hp)
        {
            HP += _hp;
        }

        private void Sleep()
        {
            HP += maxHp / 4;
            Stamina += maxStamina / 4;
        }

        private void Attack()
        {
            Random rnd = new Random();
            int extraDamage  = rnd.Next(1, 12);
            int hp = Player.Instance.HP;

            Player.Instance.UpdateHP(hp - (attack + extraDamage));
        }

    }
}
