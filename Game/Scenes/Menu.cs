using Game.Base;

namespace Game.Scenes
{
    internal class Menu : Scene
    {
        public Menu()
        {
            Add(@"                 ___====-_  _-====___                 ");
            Add(@"           _--^^^#####//      \\#####^^^--_           ");
            Add(@"        _-^##########// (    ) \\##########^-_        ");
            Add(@"       -############//  |\^^/|  \\############-       ");
            Add(@"     _/############//   (@::@)   \\############\_     ");
            Add(@"    /#############((     \\//     ))#############\    ");
            Add(@"   -###############\\    (oo)    //###############-   ");
            Add(@"  -#################\\  / VV \  //#################-  ");
            Add(@" -###################\\/      \//###################- ");
            Add(@"_#/|##########/\######(   /\   )######/\##########|\#_");
            Add(@"|/ |#/\#/\#/\/  \#/\##\  |  |  /##/\#/  \/\#/\#/\#| \|");
            Add(@"`  |/  V  V  `   V  \#\| |  | |/#/  V   '  V  V  \|  '");
            Add(@"   `   `  `      `   / | |  | | \   '      '  '   '   ");
            Add(@"                    (  | |  | |  )                    ");
            Add(@"                   __\ | |  | | /__                   ");
            Add(@"                  (vvv(VVV)(VVV)vvv)                  ");
            SetMenuMargin();
            Add("1) Jogar    ");
            Add("2) Carregar ");
            Add("3) Database ");
            Add("4) Sair     ");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new CharacterSelection();
            }

            if (option == "2")
            {
                return new LoadCharacter();
            }

            if (option == "3")
            {
                return new DatabaseActions();
            }

            if (option == "4")
            {
                Environment.Exit(0);
            }

            return new Menu();
        }
    }
}
