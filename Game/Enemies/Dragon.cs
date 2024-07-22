namespace Game.Enemies
{
    internal class Dragon : Enemy
    {
        private const string name = "Dragão vermelho";
        private const int maxHp = 200;
        private const int maxStamina = 200;
        private const int attack = 40;
        private const int gold = 300;
        private static readonly string[] body = 
        {
            @" <>=======()                           ",
            @"(/\___   /|\\          ()==========<>_ ",
            @"      \_/ | \\        //|\   ______/ \)",
            @"        \_|  \\      // | \_/          ",
            @"          \|\/|\_   //  /\/            ",
            @"           (oo)\ \_//  /               ",
            @"          //_/\_\/ /  |                ",
            @"         @@/  |=\  \  |                ",
            @"              \_=\_ \ |                ",
            @"                \==\ \|\_              ",
            @"             __(\===\(  )\             ",
            @"            (((~) __(_/   |            ",
            @"                 (((~) \  /            ",
            @"                 ______/ /             ",
            @"                 '------'              "
        };

        public Dragon() : base(name, maxHp, maxStamina, attack, body, gold)
        {

        }
    }
}
