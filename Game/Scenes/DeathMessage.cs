using Game.Base;

namespace Game.Scenes
{
    internal class DeathMessage : Scene
    {
        public DeathMessage(string _msg = "Você morreu.")
        {
            Space();
            Add(@"    .-.    ");
            Add(@"   (x.x)   ");
            Add(@"    |=|    ");
            Add(@"   __|__   ");
            Add(@"  /.=|=.\  ");
            Add(@" / .=|=. \ ");
            Add(@" \\(_=_)// ");
            Add(@"  (:| |:)  ");
            Add(@"   || ||   ");
            Add(@"   || ||   ");
            Add(@"  ==' '==  ");
            Space();
            Add($"{_msg}");
            SetMenuMargin();
            Add("1) Tentar de novo    ");
            Add("2) Voltar para o menu");
            Add("3) Sair do jogo      ");
        }

        public override Scene ProccessUserOption(string option)
        {
            Player.UpdateHP(100);
            Player.UpdateStamina(100);
            Player.Gold = 50;

            if (option == "1")
            {
                return new City();
            }

            if (option == "2")
            {
                return new Menu();
            }

            if (option == "3")
            {
                Environment.Exit(0);
            }

            return new DeathMessage();
        }
    }
}
