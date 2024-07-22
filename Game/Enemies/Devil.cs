namespace Game.Enemies
{
    internal class Devil : Enemy
    {
        private const string name = "Demônio bestial";
        private const int maxHp = 500;
        private const int maxStamina = 500;
        private const int attack = 200;
        private const int gold = 3000;
        private static readonly string[] body =
        {
            @"                            ,-.                            ",
            @"       ___,---.__          /'|`\          __,---,___       ",
            @"    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.    ",
            @" /      ___//              `. ,'          ,  , \___      \ ",
            @"|    ,-'   `-.__   _         |        ,    __,-'   `-.    |",
            @"|   /          /\_  `   .    |    ,      _/\          \   |",
            @"\  |           \ \`-.___ \   |   / ___,-'/ /           |  /",
            @" \  \           | `._ x `\\  |  //'   _,' |           /  / ",
            @"  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'  ",
            @"             |__   /|\_,--.,-.--,--._/|\   __|             ",
            @"             /  `./  \\`\ |  |  | /,//' \,'  \             ",
            @"            /   /     ||--+--|--+-/-|     \   \            ",
            @"            \   \__, \_     `~'     _/ .__/   /            ",
            @"             `-._,-'   `-._______,-'   `-._,-'             "
        };

        public Devil() : base(name, maxHp, maxStamina, attack, body, gold)
        {

        }
    }
}
