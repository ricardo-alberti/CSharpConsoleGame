using Game.Base;
using Game.Database;

namespace Game.Scenes
{
    internal class LoadCharacter : Scene
    {
        private readonly Connection conn = new Connection();

        public LoadCharacter()
        {
            displayPlayers();
        }

        private void displayPlayers()
        {
            List<string> players = conn.PlayerList();

            foreach (string row in players)
            {
                Add(row);
            }
        }

        public override Scene ProccessUserOption(string option)
        {
            int optionNumber = Convert.ToInt32(option);
            conn.LoadCharacter(optionNumber);

            return new City();
        }
    }
}
