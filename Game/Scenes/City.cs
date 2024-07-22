using Game.Base;

namespace Game.Scenes
{
    internal class City : Scene
    {
        public City()
        {
            Space();
            Add("                       .|                               ");
            Add("                       | |                              ");
            Add("                       |'|            ._____'           ");
            Add("               ___    |  |            |.   |' .---'|    ");
            Add("       _    .-'   '-. |  |     .--'|  ||   | _|    |    ");
            Add("    .-'|  _.|  |    ||   '-__  |   |  |    ||      |    ");
            Add("    |' | |.    |    ||       | |   |  |    ||      |    ");
            Add(" ___|  '-'     '    ''       '-'   '-.'    '`      |____");
            Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~   ");
            SetMenuMargin();
            Add("1) Entrar no castelo ");
            Add("2) Ir para a loja    ");
            Add("3) Entrar na floresta");
            Add("4) Ir para a caverna ");
            Add("5) Voltar para o menu");
        }

        public override Scene ProccessUserOption(string option)
        {
            if (option == "1")
            {
                return new Castle();
            }

            if (option == "2")
            {
                return new Store();
            }

            if (option == "3")
            {
                return new Forest();
            }

            if (option == "4")
            {
                return new Cavern();
            }

            if (option == "5")
            {
                return new Menu();
            }

            return new City();
        }
    }
}
