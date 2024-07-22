using Game.Base;
using Game.Enemies;

namespace Game.Scenes
{
    internal class Forest : Scene
    {
        public Forest()
        {
            Space();
            Add("   __________  ");
            Add("  /l____;;___l ");
            Add(" | /         / ");
            Add(" `. ())oo() .  ");
            Add("  |l(%()*^^()^l");
            Add(" %| |-%-------|");
            Add("% l | %  ))   |");
            Add("%  l|%________|");
            SetMenuMargin();
            Add("1) Saquear báu secreto ");
            Add("2) Voltar para a cidade");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new Battle(new Mage());
            }

            if (option == "2")
            {
                return new City();
            }

            return new Forest();
        }
    }
}
