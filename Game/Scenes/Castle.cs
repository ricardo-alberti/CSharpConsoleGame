using Game.Base;
using Game.Enemies;

namespace Game.Scenes
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Space();
            Add("                        |--__                     ");
            Add("                        |                         ");
            Add("                        X                         ");
            Add("               |-___   / l       |--__            ");
            Add("               |      =====      |                ");
            Add("               X      | .:|      X                ");
            Add("              / l     | O |     / l               ");
            Add("             =====   |:  . |   =====              ");
            Add("             |.: |__| .   : |__| :.|              ");
            Add("             |  :|. :  ...   : |.  |              ");
            Add("     __   __W| .    .  ||| .      :|W__  --       ");
            Add("   -- __  W  WWWW______'''______WWWW   W -----  --");
            Add(" -     ___  ---    ____     ____----       --__  -");
            Add("   --__    --    --__     -___        __-   _     ");
            SetMenuMargin();
            Add("1) Tomar trono         ");
            Add("2) Voltar para a cidade");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new Battle(new Devil());
            }
             
            if (option == "2")
            {
                return new City();
            }

            return new Castle();
        }
    }
}
