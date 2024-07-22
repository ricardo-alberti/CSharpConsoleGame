namespace Game.Enemies
{
    internal class Death : Enemy
    {
        private const string name = "Morte";
        private const int maxHp = 5020;
        private const int maxStamina = 5020;
        private const int attack = 505;
        private const int gold = 50000;
        private static readonly string[] body =
        {
            @"                 /\    ",
            @"                 ||    ",
            @"   ____ (((+))) _||_   ",
            @"  /.--.\  .-.  /.||.\  ",
            @" /.,   \\(0.0)// || \\ ",
            @"/;`';/\ \\|m|//  ||  ;\",
            @"|:   \ \__`:`____||__:|",
            @"|:    \__ \T/ (@~)(~@)|",
            @"|:    _/|     |\_\/  :|",
            @"|:   /  |     |  \   :|",
            @"|'  /   |     |   \  '|",
            @" \_/    |     |    \_/ ",
            @"        |     |        ",
            @"        |_____|        ",
            @"        |_____|        "
        };

        public Death() : base(name, maxHp, maxStamina, attack, body, gold)
        {

        }
    }
}
