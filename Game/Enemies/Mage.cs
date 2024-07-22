namespace Game.Enemies
{
    internal class Mage : Enemy
    {
        private const string name = "Mago da floresta";
        private const int maxHp = 120;
        private const int maxStamina = 120;
        private const int attack = 25;
        private const int gold = 500;
        private static readonly string[] body =
        {
            @"              _,-'|    ",
            @"           ,-'._  |    ",
            @" .||,      |####\ |    ",
            @"\.`',/     \####| |    ",
            @"= ,. =      |###| |    ",
            @"/ || \    ,-'\#/,'`.   ",
            @"  ,|____,' , ,;' \| |  ",
            @" (3|\    _/|/'   _| |  ",
            @"  ||/,-''  | >-'' _,\\ ",
            @"  ||'      ==\ ,-'  ,' ",
            @"  ||       |    \    \ ",
            @"  \|       |     |    \",
            @"           |-_-_-_\_,-'",
        };

        public Mage() : base(name, maxHp, maxStamina, attack, body, gold)
        {

        }
    }
}
