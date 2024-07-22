using Game.Base;
using Game.Enemies;

namespace Game.Scenes
{
    internal class Cavern : Scene
    {
        public Cavern()
        {
            Space();
            Add("    ((     ))    ");
            Add("===  \\_v_//  ===");
            Add("  ====)_^_(====  ");
            Add("  ===/ @ @ l===  ");
            Add("  = | l_ _l | =  ");
            Add(" =   ll_ _ll   = ");
            Add("      l_ _l      ");
            Add("      (o_o)      ");
            Add("       VwV       ");
            Space();
            SetMenuMargin();
            Add("1) Acordar dragão               ");
            Add("2) Roubar cálice da imortalidade");
            Add("3) Voltar para a cidade         ");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new Battle(new Dragon());
            }

            if (option == "2")
            {
                return new Battle(new Death());
            }

            if (option == "3")
            {
                return new City();
            }

            return new Menu();
        }
    }
}
